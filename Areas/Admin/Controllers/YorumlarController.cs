using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class YorumlarController : Controller
    {
        private readonly GeziRehberimContext context;

        public YorumlarController(GeziRehberimContext context)
        {
            this.context = context;
        }

       
        public IActionResult Index()
        {
            var deger = context.Yorumlars.Include(x=>x.GidilecekYerler).ToList();
            return View(deger);
        }
        
        public IActionResult YorumSil(int id)
        {
            var deger = context.Yorumlars.Find(id);
            if (deger == null)
            {
                return NotFound("Silinecek yorum bulunamadı");
            }
            else
            {
                context.Yorumlars.Remove(deger);
                context.SaveChanges();
                return RedirectToAction("Index", "Yorumlar", new { area = "Admin" });
            }
              
        }
    }
}
