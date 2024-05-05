using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Üyeler.Controllers
{
    [Area("Üyeler")]
    [AllowAnonymous]
    [Route("Üyeler/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<UygulamaKullanıcısı> userManager;

        public DashboardController(UserManager<UygulamaKullanıcısı> userManager)
        {
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var kullanıcı = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = kullanıcı.Adı + " " + kullanıcı.Soyadı;
            ViewBag.resim = kullanıcı.ResimYolu;
            return View();
        }
    }
}
