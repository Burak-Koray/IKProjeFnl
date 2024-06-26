    using Microsoft.AspNetCore.Mvc;
    using OfficeOpenXml;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using IKProje.Models;
    using Microsoft.AspNetCore.Authorization;

    public class ExcelController : Controller
    {
        private readonly Pro02SbtContext _dbContext;

        public ExcelController(Pro02SbtContext dbContext)
        {
            _dbContext = dbContext;
        }
        [Authorize]
        public IActionResult ExportToExcel(string searchQuery)
        {
            List<Sicil> data;

            if (!string.IsNullOrEmpty(searchQuery))
            {
                data = _dbContext.Sicils.Where(s => s.Adisoyadi.Contains(searchQuery)).ToList();
            }
            else
            {
                data = _dbContext.Sicils.ToList();
            }

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Personel");

                worksheet.Cells[1, 1].Value = "Sicil No";
                worksheet.Cells[1, 2].Value = "Ad Soyad";
                worksheet.Cells[1, 3].Value = "Departman Adı";
                worksheet.Cells[1, 4].Value = "Çalışan Statüsü";
                worksheet.Cells[1, 5].Value = "Mesai Türü";
                worksheet.Cells[1, 6].Value = "Giriş Tarihi";
                worksheet.Cells[1, 7].Value = "Çıkış Tarihi";

                for (int i = 0; i < data.Count; i++)
                {
                    worksheet.Cells[i + 2, 1].Value = data[i].Sicilno;
                    worksheet.Cells[i + 2, 2].Value = data[i].Adisoyadi;
                    worksheet.Cells[i + 2, 3].Value = data[i].Bolumadi;
                    worksheet.Cells[i + 2, 4].Value = data[i].Ozelkod;
                    worksheet.Cells[i + 2, 5].Value = data[i].Mesaiadi;
                    worksheet.Cells[i + 2, 6].Value = data[i].Giristarihi;
                    worksheet.Cells[i + 2, 7].Value = data[i].Cikistarihi;
                }

                var stream = new MemoryStream();
                package.SaveAs(stream);
                stream.Position = 0;

                return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "personel.xlsx");
            }
        }
    }
