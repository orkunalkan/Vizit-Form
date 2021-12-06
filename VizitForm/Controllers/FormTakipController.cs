using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VizitForm.Models;

namespace VizitForm.Controllers
{
    public class FormTakipController : Controller
    {

        private readonly FormModel _cc;
        public FormTakipController(FormModel cc)
        {
            _cc = cc;
        }
        public IActionResult TakipVizitForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TakipVizitForm(FormTakipDataModel adData)
        {
            using StreamWriter file = new StreamWriter("ErrorLogs.txt", append: true);
            try
            {
                _cc.Add(adData);
                _cc.SaveChanges();
            }
            catch (Exception e)
            {
                file.WriteLineAsync("Veritabanına kayıt hatası. Hata Mesajı :" + e.Message);
            }
            ViewBag.message = "The Record " + adData.id + " Is Saved Succesfully ... !";

            return View();
        }
    }
}
