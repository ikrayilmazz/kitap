using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using kitap.Models;

namespace kitap.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
        {
            Kitap kitap = new Kitap
            {
                KitapAdı = "Acımak",
                YazarAdı = "Reşat Nuri Güntekin",
                YayınlanmaTarihi = new DateTime(2024, 04, 27),
                Türü = "Edebiyat",
                SayfaSayısı = 300,
                Fiyat = 100
            };

            return View(kitap);}

}
