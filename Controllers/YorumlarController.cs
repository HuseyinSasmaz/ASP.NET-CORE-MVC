using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GeziRehberim.Controllers
{
    [AllowAnonymous]
    public class YorumlarController : Controller
    {
        private readonly GeziRehberimContext context;

        public YorumlarController(GeziRehberimContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> YorumEkle()
        {
           
            return PartialView();
        }

        [HttpPost]
        public IActionResult YorumEkle(Yorumlar p)
        {
            //var rota=context.GidilecekYerlers.Include(x=>x.Yorumlars).Where(z=>z.GidilecekYerlerID==p.GidilecekYerlerID).FirstOrDefault();  
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
               p.UygulamaKullanıcısıID=int.Parse(userId);
               p.Durum = true;
                p.YorumTarihi = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                context.Yorumlars.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index", "Rotalar");
            }
            else
            {
                return RedirectToAction("GirişYap", "Giriş");
            }
          





        }
    }
}
