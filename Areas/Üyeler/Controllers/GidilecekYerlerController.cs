using GeziRehberim.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Üyeler.Controllers
{
    [Area("Üyeler")]
    [AllowAnonymous]
    [Route("Üyeler/[controller]/[action]")]
    public class GidilecekYerlerController : Controller
    {
        private readonly GeziRehberimContext context;

        public GidilecekYerlerController(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var deger = context.GidilecekYerlers.ToList();
            return View(deger);
        }

        public IActionResult RotaAra(string rotaAra)
        {
           
            if (!string.IsNullOrEmpty(rotaAra))
            {
                var bul = context.GidilecekYerlers.Where(x=>x.Şehir!=null && x.Şehir.Contains(rotaAra)).ToList();
                return View(bul);
               
            }

            return View();
        }
    }
}
