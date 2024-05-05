using FluentValidation.Results;
using GeziRehberim.Data;
using GeziRehberim.FluentValodations;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [AllowAnonymous]
	[Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class RehberlerController : Controller
	{
		private readonly GeziRehberimContext context;

		public RehberlerController(GeziRehberimContext context)
		{
			this.context = context;
		}

		public IActionResult Index()
		{
			var deger = context.Rehbers.ToList();
			return View(deger);
		}
		[HttpGet]
		public IActionResult RehberEkle()
        {
			return View();
        }
        [HttpPost]
        public IActionResult RehberEkle(Rehber rehber)
        {
			

			
                context.Rehbers.Add(rehber);
                context.SaveChanges();
                return RedirectToAction("Index");
           
             
        }
        public IActionResult RehberDüzenle(int id)
		{
			var deger=context.Rehbers.Find(id);

			return View(deger);
		}
        [HttpPost]
        public IActionResult RehberDüzenle(Rehber rehber)
        {
			if (ModelState.IsValid)
			{
                context.Rehbers.Update(rehber);
                context.SaveChanges();
                return RedirectToAction("Index", "Default");
            }
           return View(rehber);

           
        }
    }
}
