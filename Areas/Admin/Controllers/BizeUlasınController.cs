using GeziRehberim.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public class BizeUlasınController : Controller
    {
     private readonly GeziRehberimContext context;

        public BizeUlasınController(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IActionResult BizeUlasınAktif()
        {         
            var deger =context.BizeUlasıns.Where(x=>x.Durum==true).ToList();    
            return View(deger);
        }
        public IActionResult BizeUlasınPasif()
        {
            var deger = context.BizeUlasıns.Where(x => x.Durum == false).ToList();
            return View(deger);
        }
    }
}
