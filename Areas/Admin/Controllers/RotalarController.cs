using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
   
    public class RotalarController : Controller
    {
        private readonly GeziRehberimContext context;

        public RotalarController(GeziRehberimContext context)
        {
            this.context = context;
        }

       
        public IActionResult Index()
        {
            var deger=context.GidilecekYerlers.ToList();    
            return View(deger);
        }

        [HttpGet]
        public IActionResult RotaEkle()
        {
           
            return View();
        }

        [HttpPost]
        public IActionResult RotaEkle(GidilecekYerler gidilecekYerler)
        {
            context.GidilecekYerlers.Add(gidilecekYerler);
            context.SaveChanges();
            return RedirectToAction("Index","Rotalar",new {area="Admin"});
        }

        [HttpGet]
        public IActionResult RotaGüncelle(int id)
        {
            var deger = context.GidilecekYerlers.Find(id);
            return View(deger);
        }

        [HttpPost]
        public IActionResult RotaGüncelle(GidilecekYerler gidilecekYerler)
        {
            context.GidilecekYerlers.Update(gidilecekYerler);
            context.SaveChanges();
            return RedirectToAction("Index", "Rotalar", new { area = "Admin" });
        }

        public IActionResult RotaSil(int id) 
        {
            var deger = context.GidilecekYerlers.Find(id);
            context.GidilecekYerlers.Remove(deger);
            context.SaveChanges();
            return RedirectToAction("Index", "Rotalar", new { area = "Admin" });  
        }
    }
}
