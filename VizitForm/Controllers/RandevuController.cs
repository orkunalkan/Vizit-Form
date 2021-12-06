using Microsoft.AspNetCore.Mvc;
using VizitForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace VizitForm.Controllers
{
    public class RandevuController : Controller
    {

        private readonly FormModel _cc;
        public RandevuController(FormModel cc)
        {
            _cc = cc;
        }

        public IActionResult Registers()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registers(RegisterDataModel ec)
        {
            using StreamWriter file = new StreamWriter("ErrorLogs.txt", append: true);
            //logger.Info("Enter the register controller. Register Method");
            
            try
            {
                file.WriteLineAsync("Veritabanına kayıt başarılı");
                _cc.Add(ec);
                _cc.SaveChanges();
            }
            catch (Exception e)
            {
                file.WriteLineAsync("Veritabanına kayıt hatası. Hata Mesajı :" + e.Message);
            }
            ViewBag.message = "The Record " + ec.Kimlik + " Is Saved Succesfully ... !";
            //throw new Exception("Veri tabanı kayıt hatası");
            //logger.Info("Exit register controller. Register success");
            //logger.Info("Exit register controller. Register failure");
            
            return View();
        }

    }

}
