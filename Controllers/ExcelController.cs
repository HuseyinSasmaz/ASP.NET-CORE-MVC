using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using OfficeOpenXml;

namespace GeziRehberim.Controllers
{
       [AllowAnonymous]
    public class ExcelController : Controller
    { 
       private readonly GeziRehberimContext context;

        public ExcelController(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IActionResult ExcelDosyaOlustur()
        {
            var liste = context.GidilecekYerlers.ToList();
             using(var page=new ExcelPackage())
             {
                var worksheet = page.Workbook.Worksheets.Add("Rotalar");
                worksheet.Cells[1, 1].Value = "Şehir";
                worksheet.Cells[1, 2].Value = "Süre";
                worksheet.Cells[1, 3].Value = "Kapesite";
                worksheet.Cells[1, 4].Value = "Fiyat";

                int row = 2;
                foreach (var item in liste)
                {
                    worksheet.Cells[row, 1].Value = item.Şehir;
                    worksheet.Cells[row, 2].Value = item.GündüzGece;
                    worksheet.Cells[row, 3].Value = item.Kapasite;
                    worksheet.Cells[row, 4].Value = item.Fiyat;

                    row++;
                }
                var excelBytes = page.GetAsByteArray();
                return File(excelBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Rotalar.xlsx");
            }

            
        }
       

    }
}
