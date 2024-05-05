using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class KullanıcılarController : Controller
    {
        private readonly UserManager<UygulamaKullanıcısı> userManager;
        private readonly GeziRehberimContext context;

        public KullanıcılarController(UserManager<UygulamaKullanıcısı> userManager, GeziRehberimContext context)
        {
            this.userManager = userManager;
            this.context = context;
        }

        public async Task<IActionResult> Index()
        {
            var deger = await userManager.Users.ToListAsync();
            return View(deger);
        }

        public async Task<IActionResult> KullanıcıSil(int id)
        {
            var kullanıcı = await userManager.FindByIdAsync(id.ToString());
            if (kullanıcı==null)
            {
                return View();
            }

            var sonuc = await userManager.DeleteAsync(kullanıcı);
            if (sonuc.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public async Task<IActionResult> KullanıcıDüzenle(int id)
        {
            var kullanıcı = await userManager.FindByIdAsync(id.ToString());
            if (kullanıcı==null)
            {
                return View();
            }
            else
            {
                return View(kullanıcı);
            }
           
        }
        [HttpPost]
        public async Task<IActionResult> KullanıcıDüzenle(UygulamaKullanıcısı uygulamaKullanıcısı) 
        {
            var sonuc = await userManager.UpdateAsync(uygulamaKullanıcısı);
            if (sonuc.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
        public IActionResult KullanıcıYorum(int id)
        {
            var deger = context.Yorumlars.Include(x=>x.GidilecekYerler).ToList();
            return View(deger);
        }

        public IActionResult KullanıcıRezervasyon(int id)
        {
            var deger = context.Rezervasyons.Include(x => x.GidilecekYerler).ToList();
            return View(deger);
        }
    }
}
