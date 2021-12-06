using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VizitForm.Models;
using System.Text;
using OfficeOpenXml;
using System.IO;

namespace VizitForm.Controllers
{
    public class AramaController : Controller
    {
        private readonly FormModel _context;
        public AramaController(FormModel context)
        {
            _context = context;
        }
        //public async Task<IActionResult> Search(string a)
        //{
        //    var surname = _context.Randevu.AsNoTracking();

        //    var query = from s in surname
        //                where s.Soyad == a
        //                select (s);

        //    if (!String.IsNullOrEmpty(a))
        //    {
        //        query = query.Where(s => s.Soyad.Contains(a));
        //    }


        //    return View(await query.ToListAsync());
        //}
        public async Task<IActionResult> Search(int? b)
        {
            using StreamWriter file = new StreamWriter("ErrorLogs.txt", append: true);
            
                var surname = _context.Form.AsNoTracking();
           
                var query = from s in surname
                        where s.tc == b
                        select (s);
            try
            {
                if (!String.IsNullOrEmpty(b.ToString()))
                {
                    query = query.Where(s => s.tc.ToString().Contains(b.ToString()));
                }
                return View(await query.ToListAsync());
            }
            catch (Exception e)
            {
                await file.WriteLineAsync("Aranan sonuç bulunamadı. Hata Mesajı :" + e.Message);
            }


            return View();



        }
    }
}
