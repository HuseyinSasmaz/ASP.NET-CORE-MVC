using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GeziRehberim.Areas.Üyeler.Controllers
{
    [Area("Üyeler")]
    [AllowAnonymous]
    [Route("Üyeler/[controller]/[action]")]
    public class RezervasyonController : Controller
    {
        private readonly GeziRehberimContext context;
        private readonly UserManager<UygulamaKullanıcısı> userManager;

        public RezervasyonController(GeziRehberimContext context, UserManager<UygulamaKullanıcısı> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> AktifRezervasyonlarım()
        {
            var kullanıcı = await userManager.FindByNameAsync(User.Identity.Name);
            var liste= context.Rezervasyons.Include(x => x.GidilecekYerler).Where(z => z.UygulamaKullanıcısıId == kullanıcı.Id && z.Statu == "Onaylandı").ToList();
            return View(liste);
        }

        public async Task<IActionResult> GeçmişRezervasyonlarım()
        {
            var kullanıcı = await userManager.FindByNameAsync(User.Identity.Name);
            var liste = context.Rezervasyons.Include(x => x.GidilecekYerler).Where(z => z.UygulamaKullanıcısıId == kullanıcı.Id && z.Statu == "Geçmiş randevu").ToList();
            return View(liste);
        }
        public async Task<IActionResult> OnayBekleyenRezervasyonlarım()
        {
           
            var kullanıcı = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.kullanıcıId = kullanıcı.Id;
            var liste = context.Rezervasyons.Include(x=>x.GidilecekYerler).Where(z=>z.UygulamaKullanıcısıId == kullanıcı.Id && z.Statu== "Onay bekliyor").ToList();
            return View(liste);
            
        }

        [HttpGet]
        public IActionResult YeniRezervasyon()
        {
            List<SelectListItem> deger = (from x in context.GidilecekYerlers.ToList()
                                          select new SelectListItem
                                          {
                                               Text=x.Şehir,
                                               Value=x.GidilecekYerlerID.ToString()
                                          }).ToList();
            ViewBag.v = deger;
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> YeniRezervasyon(Rezervasyon p)
        {
            var kullanıcı = await userManager.FindByNameAsync(User.Identity.Name);
            p.UygulamaKullanıcısıId=kullanıcı.Id;
            p.Statu = "Onay bekliyor";
            context.Rezervasyons.Add(p);
            context.SaveChanges(); 
            return RedirectToAction("OnayBekleyenRezervasyonlarım", "Rezervasyon");
        }
    }
}
