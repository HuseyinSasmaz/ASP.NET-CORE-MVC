using GeziRehberim.Data;
using GeziRehberim.FluentValodations;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
   // [Route("Admin/[controller]/[action]")]
    public class DuyurularController : Controller
    {
        private readonly GeziRehberimContext context;

        public DuyurularController(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var deger = context.Duyurulars.ToList();
            foreach (var item in deger)
            {
                if (item.Baslık!=null && item.İcerik!=null && item.Tarih!=null )
                {
                    return View(deger);
                }
            }
            return View();
        }       

        [HttpGet]
        public IActionResult DuyuruEkle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DuyuruEkle(Duyurular duyurular)
        {
            var validator = new DuyurularValidator();
            var validatiionResult=validator.Validate(duyurular);
            if (validatiionResult.IsValid)
            {
               
                    duyurular.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    context.Duyurulars.Add(duyurular);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                
            }
           
                foreach (var hata in validatiionResult.Errors)
                {
                    ModelState.AddModelError(hata.PropertyName, hata.ErrorMessage);
                }

            
           
            return View(duyurular);
           
        }
        public IActionResult DuyuruSil(int id)
        {
            var deger = context.Duyurulars.ToList();
            var bulID = context.Duyurulars.Find(id);
            context.Duyurulars.Remove(bulID);
            context.SaveChanges();
            return RedirectToAction("Index","Duyurular",deger);
        }
        [HttpGet]
        public IActionResult DuyuruGuncelle(int id)
        {
            var deger = context.Duyurulars.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult DuyuruGuncelle(Duyurular model)
        {
            if (ModelState.IsValid)
            {
                model.Tarih = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                context.Duyurulars.Update(model);
                context.SaveChanges();
                return RedirectToAction("Index", "Duyurular");
            }

            return View(model);
        }
    }
}
