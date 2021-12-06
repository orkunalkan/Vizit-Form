using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VizitForm.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;
using OfficeOpenXml;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;

namespace VizitForm.Controllers
{
    public class FormController : Controller
    {
        private readonly FormModel _cc;
        public FormController(FormModel cc)
        {
            _cc = cc;
        }
        public IActionResult VizitForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VizitForm(FormDataModel adData)
        {
            using StreamWriter file = new StreamWriter("ErrorLogs.txt", append: true);
            try
            {
                _cc.Add(adData);
                _cc.SaveChanges();
            }
            catch (Exception e)
            {
                await file.WriteLineAsync("Veritabanına kayıt hatası. Hata Mesajı :" + e.Message);
            }
            ViewBag.message = "The Record Is Saved Succesfully ... !";

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var files = new FileInfo(fileName: @"C:\Users\orkuna\Desktop\xml\Main.xlsx");
            List<FormDataModel> output = new List<FormDataModel>() { adData };
            await SaveExcelFile(output, files);
            return View();

        }

        private static async Task SaveExcelFile(List<FormDataModel> adData, FileInfo file)
        {
            DeleteIfExists(file);
            using var package = new ExcelPackage(file);

            var ws = package.Workbook.Worksheets.Add(Name: "MainReport");

            var range = ws.Cells[Address: "A1"].LoadFromCollection(adData, PrintHeaders: true); 
            //var range = ws.Cells[Address: ].LoadFromCollection(adData, PrintHeaders: true);

            range.AutoFitColumns();

            await package.SaveAsync();
        }
        private static void DeleteIfExists(FileInfo file)
        {

            if (file.Exists)
            {
                file.Delete();
            }
        }


    }
}
