using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeziRehberim.Controllers
{
    [AllowAnonymous]
    public class RotalarController : Controller
    {
        private readonly GeziRehberimContext context;
        private readonly UserManager<UygulamaKullanıcısı> userManager;

        public RotalarController(GeziRehberimContext context, UserManager<UygulamaKullanıcısı> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var deger=context.GidilecekYerlers.ToList();
            return View(deger);
        }

        [HttpGet]
        public async Task<IActionResult> RotalarDetay(int id)
        {
            var rehber = context.GidilecekYerlers.Where(x => x.GidilecekYerlerID == id).Include(x=>x.Rehber).FirstOrDefault();
            if (User.Identity.IsAuthenticated)
            {
                if (rehber.Rehber !=null)
                {
                    var deger1 = await userManager.FindByNameAsync(User.Identity.Name);
                    if (deger1 !=null)
                    {
                        ViewBag.dgr = deger1.Adı + " " + deger1.Soyadı;
                    }
                   
                }
                
            }
            

            ViewBag.id = id;
            var deger = context.GidilecekYerlers.Where(x => x.GidilecekYerlerID == id).ToList();   
            //var deger2=context.GidilecekYerlers.Include(y=>y.Yorumlars).FirstOrDefault(z=>z.GidilecekYerlerID==id);
            return View(rehber);
        }

       
    }
}
