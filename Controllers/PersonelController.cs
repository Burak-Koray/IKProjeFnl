using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IKProje.Models;

namespace IKProje.Controllers
{
    public class PersonelController : Controller
    {
        private readonly Pro02SbtContext dbContext;

        public PersonelController(Pro02SbtContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Authorize]
        [HttpGet]
        public IActionResult Add()
        {
            var bolumler = dbContext.Bolumdeparts
                                    .Where(b => b.Tipi == "a")
                                    .Select(b => new SelectListItem
                                    {
                                        Value = b.Adi.ToString(),
                                        Text = b.Adi
                                    }).ToList();

            ViewBag.Bolumler = new SelectList(bolumler, "Value", "Text");

            var mesaituru = dbContext.Periyods
                               .Select(m => new SelectListItem
                               {
                                   Value = m.Tanim.ToString(),
                                   Text = m.Tanim.ToString()
                               }).ToList();

            ViewBag.Mesaituru = new SelectList(mesaituru, "Value", "Text");

            var ozelkod = new List<SelectListItem>
            {
                new SelectListItem { Text = "SÖZLEŞMELİ" },
                new SelectListItem { Text = "SENDİKALI" },
                new SelectListItem { Text = "K.D.MEMUR" },
                new SelectListItem { Text = "STAJYER" },
                new SelectListItem { Text = "TAŞERON" },
                new SelectListItem { Text = "KAPS.DIŞI" },
                new SelectListItem { Text = "SRT TEKNİK" },
                new SelectListItem { Text = "SADIK İNŞ" },
                new SelectListItem { Text = "İŞ KURUMU" },
                new SelectListItem { Text = "YEMEKHANE" },
                new SelectListItem { Text = "VERİ ÇEVRE" }
            };

            ViewBag.Ozelkod = ozelkod;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Sicil viewModel)
        {
            if (ModelState.IsValid)
            {
                var sicil = new Sicil
                {
                    Sicilno = viewModel.Sicilno,
                    Adisoyadi = viewModel.Adisoyadi,
                    Bolumadi = viewModel.Bolumadi,
                    Ozelkod = viewModel.Ozelkod,
                    Mesaiadi = viewModel.Mesaiadi,
                    Giristarihi = viewModel.Giristarihi,
                    Cikistarihi = viewModel.Cikistarihi,
                };

                await dbContext.Sicils.AddAsync(sicil);
                await dbContext.SaveChangesAsync();

                return RedirectToAction("List");
            }

            var bolumler = dbContext.Bolumdeparts
                                    .Where(b => b.Tipi == "a")
                                    .Select(b => new SelectListItem
                                    {
                                        Value = b.Adi.ToString(),
                                        Text = b.Adi
                                    }).ToList();

            ViewBag.Bolumler = new SelectList(bolumler, "Value", "Text");

            var mesaituru = dbContext.Periyods
                               .Select(m => new SelectListItem
                               {
                                   Value = m.Tanim.ToString(),
                                   Text = m.Tanim.ToString()
                               }).ToList();

            ViewBag.Mesaituru = new SelectList(mesaituru, "Value", "Text");

            var ozelkodList = new List<SelectListItem>
            {
                new SelectListItem { Text = "SÖZLEŞMELİ" },
                new SelectListItem { Text = "SENDİKALI" },
                new SelectListItem { Text = "K.D.MEMUR" },
                new SelectListItem { Text = "STAJYER" },
                new SelectListItem { Text = "TAŞERON" },
                new SelectListItem { Text = "KAPS.DIŞI" },
                new SelectListItem { Text = "SRT TEKNİK" },
                new SelectListItem { Text = "SADIK İNŞ" },
                new SelectListItem { Text = "İŞ KURUMU" },
                new SelectListItem { Text = "YEMEKHANE" },
                new SelectListItem { Text = "VERİ ÇEVRE" }
            };

            ViewBag.Ozelkod = ozelkodList;

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> List(
    string? searchQuery,
    string? sortBy,
    string? sortDirection,
    int pageNumber = 1)
        {
            // Verileri sorgula
            var personelQuery = dbContext.Sicils.AsQueryable();

            // Arama sorgusu
            if (!String.IsNullOrWhiteSpace(searchQuery))
            {
                personelQuery = personelQuery.Where(p => p.Adisoyadi.Contains(searchQuery));
            }

            // Sıralama işlemi
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);
                personelQuery = sortBy.ToLowerInvariant() switch
                {
                    "sicilno" => isDesc ? personelQuery.OrderByDescending(x => x.Sicilno) : personelQuery.OrderBy(x => x.Sicilno),
                    "adisoyadi" => isDesc ? personelQuery.OrderByDescending(x => x.Adisoyadi) : personelQuery.OrderBy(x => x.Adisoyadi),
                    "bolumadi" => isDesc ? personelQuery.OrderByDescending(x => x.Bolumadi) : personelQuery.OrderBy(x => x.Bolumadi),
                    "ozelkod" => isDesc ? personelQuery.OrderByDescending(x => x.Ozelkod) : personelQuery.OrderBy(x => x.Ozelkod),
                    "mesaiadi" => isDesc ? personelQuery.OrderByDescending(x => x.Mesaiadi) : personelQuery.OrderBy(x => x.Mesaiadi),
                    "giristarihi" => isDesc ? personelQuery.OrderByDescending(x => x.Giristarihi) : personelQuery.OrderBy(x => x.Giristarihi),
                    "cikistarihi" => isDesc ? personelQuery.OrderByDescending(x => x.Cikistarihi) : personelQuery.OrderBy(x => x.Cikistarihi),
                    _ => personelQuery // Varsayılan durum
                };
            }

            int pageSize = 30;
            var totalCount = await personelQuery.CountAsync();
            var totalPages = (int)Math.Ceiling(totalCount / (double)pageSize);

            // Eğer toplam sayfa sayısı 0 ise, sayfa numarasını 1 olarak ayarla
            if (totalPages == 0)
            {
                totalPages = 1;
            }

            // İstenen sayfa numarasını belirle
            pageNumber = Math.Clamp(pageNumber, 1, totalPages);

            // Verileri seç ve sayfa numarasına göre filtrele
            var pagedPersonel = await personelQuery
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            // View'e verileri ve diğer bilgileri gönder
            ViewBag.SearchQuery = searchQuery;
            ViewBag.SortBy = sortBy;
            ViewBag.SortDirection = sortDirection;
            ViewBag.TotalPages = totalPages;
            ViewBag.PageNumber = pageNumber;

            return View(pagedPersonel);
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var personel = await dbContext.Sicils.FindAsync(id);

            if (personel == null)
            {
                return NotFound();
            }

            var bolumler = dbContext.Bolumdeparts
                                    .Where(b => b.Tipi == "a")
                                    .Select(b => new SelectListItem
                                    {
                                        Value = b.Adi.ToString(),
                                        Text = b.Adi
                                    }).ToList();

            ViewBag.Bolumler = new SelectList(bolumler, "Value", "Text");

            var ozelkodList = new List<SelectListItem>
            {
                new SelectListItem { Text = "SÖZLEŞMELİ" },
                new SelectListItem { Text = "SENDİKALI" },
                new SelectListItem { Text = "K.D.MEMUR" },
                new SelectListItem { Text = "STAJYER" },
                new SelectListItem { Text = "TAŞERON" },
                new SelectListItem { Text = "KAPS.DIŞI" },
                new SelectListItem { Text = "SRT TEKNİK" },
                new SelectListItem { Text = "SADIK İNŞ" },
                new SelectListItem { Text = "İŞ KURUMU" },
                new SelectListItem { Text = "YEMEKHANE" },
                new SelectListItem { Text = "VERİ ÇEVRE" }
            };

            ViewBag.Ozelkod = ozelkodList;

            var mesaituru = dbContext.Periyods
                                     .Select(m => new SelectListItem
                                     {
                                         Value = m.Tanim.ToString(),
                                         Text = m.Tanim.ToString()
                                     }).ToList();

            ViewBag.Mesaituru = new SelectList(mesaituru, "Value", "Text");

            return View(personel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Sicil editsicil)
        {
            if (ModelState.IsValid)
            {
                var existingSicil = await dbContext.Sicils.FindAsync(editsicil.SId);

                if (existingSicil != null)
                {
                    existingSicil.Sicilno = editsicil.Sicilno;
                    existingSicil.Adisoyadi = editsicil.Adisoyadi;
                    existingSicil.Bolumadi = editsicil.Bolumadi;
                    existingSicil.Ozelkod = editsicil.Ozelkod;
                    existingSicil.Mesaiadi = editsicil.Mesaiadi;
                    existingSicil.Giristarihi = editsicil.Giristarihi;
                    existingSicil.Cikistarihi = editsicil.Cikistarihi;

                    await dbContext.SaveChangesAsync();

                    return RedirectToAction("Edit", new { id = editsicil.SId });
                }
            }

            var bolumler = dbContext.Bolumdeparts
                                    .Where(b => b.Tipi == "a")
                                    .Select(b => new SelectListItem
                                    {
                                        Value = b.Adi.ToString(),
                                        Text = b.Adi
                                    }).ToList();

            ViewBag.Bolumler = new SelectList(bolumler, "Value", "Text");

            var ozelkodList = new List<SelectListItem>
            {
                new SelectListItem { Text = "SÖZLEŞMELİ" },
                new SelectListItem { Text = "SENDİKALI" },
                new SelectListItem { Text = "K.D.MEMUR" },
                new SelectListItem { Text = "STAJYER" },
                new SelectListItem { Text = "TAŞERON" },
                new SelectListItem { Text = "KAPS.DIŞI" },
                new SelectListItem { Text = "SRT TEKNİK" },
                new SelectListItem { Text = "SADIK İNŞ" },
                new SelectListItem { Text = "İŞ KURUMU" },
                new SelectListItem { Text = "YEMEKHANE" },
                new SelectListItem { Text = "VERİ ÇEVRE" }
            };

            ViewBag.Ozelkod = ozelkodList;

            var mesaituru = dbContext.Periyods
                                     .Select(m => new SelectListItem
                                     {
                                         Value = m.Tanim.ToString(),
                                         Text = m.Tanim.ToString()
                                     }).ToList();

            ViewBag.Mesaituru = new SelectList(mesaituru, "Value", "Text");

            return View(editsicil);
        }
        [HttpPost]
        public IActionResult Delete(Sicil sicil)
        {
            var personel = dbContext.Sicils.Find(sicil.SId);
            if (personel != null)
            {
                dbContext.Sicils.Remove(personel);
                dbContext.SaveChanges();

                return RedirectToAction("list");
            }

            return RedirectToAction("Edit", new { id = sicil.SId });
        }
    }
}
