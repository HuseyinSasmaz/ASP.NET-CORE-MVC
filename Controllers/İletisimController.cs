using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Controllers
{
    public class İletişimController : Controller
    {
        private readonly GeziRehberimContext context;

        public İletişimController(GeziRehberimContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(İletişimViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                context.BizeUlasıns.Add(new BizeUlasın
                {
                   İsim=viewModel.İsim,
                   MailAdresi=viewModel.MailAdresi,
                   Baslık=viewModel.Baslık,
                   Mesaj=viewModel.Mesaj,
                   Durum=true,
                   MesajTarihi=Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                context.SaveChanges();
                RedirectToAction("Index", "Default");
            }
            return View(viewModel);
        }
    }
}
