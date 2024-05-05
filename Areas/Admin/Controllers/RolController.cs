using GeziRehberim.Areas.Admin.Models;
using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static GeziRehberim.Areas.Admin.Models.ApiBookingHotelViewModel;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/Rol")]
    [AllowAnonymous]
    public class RolController : Controller
    {
        private readonly GeziRehberimContext _context;
        private readonly Microsoft.AspNetCore.Identity.UserManager<UygulamaKullanıcısı> userManager;
        private readonly Microsoft.AspNetCore.Identity.RoleManager<UygulamaRolü> roleManager;

        public RolController(GeziRehberimContext context, Microsoft.AspNetCore.Identity.UserManager<UygulamaKullanıcısı> userManager, Microsoft.AspNetCore.Identity.RoleManager<UygulamaRolü> roleManager)
        {
            _context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        [Route("Index")]
        public IActionResult Index()
        {

            var liste = _context.Roles.ToList();
            return View(liste);
        }

        [HttpGet]
        [Route("RolEkle")]
        public IActionResult RolEkle()
        {


            return View();

        }
        [HttpPost]
        [Route("RolEkle")]
        public IActionResult RolEkle(RolViewModel rolViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Roles.Add(new UygulamaRolü
                {
                    Name = rolViewModel.RolAdı

                });
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }

        [Route("RolSil/{id}")]
        public IActionResult RolSil(int id)
        {
            var deger = _context.Roles.Find(id);
            _context.Remove(deger);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        [Route("RolGüncelle/{id}")]
        public IActionResult RolGüncelle(int id)
        {
            var deger = _context.Roles.Find(id);

            RolViewModel model = new RolViewModel
            {
                RolID = deger.Id,
                RolAdı = deger.Name
            };
            return View(model);
        }

        [HttpPost]
        [Route("RolGüncelle/{id}")]
        public IActionResult RolGüncelle(RolViewModel model)
        {
            var deger = _context.Roles.FirstOrDefault(x => x.Id == model.RolID);
            deger.Name = model.RolAdı;
            deger.Id = model.RolID;
            _context.Update(deger);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [Route("KullanıcıListestesi")]
        public IActionResult KullanıcıListestesi()
        {

            var klnListe =  userManager.Users.ToList();
            return View(klnListe);
        }

        [Route("RolAta/{id}")]
        [HttpGet]
        public async Task<IActionResult> RolAta(int id)
        {
            var user= userManager.Users.FirstOrDefault(x=>x.Id==id);
            TempData["userID"] = user.Id;
            var roles = roleManager.Roles.ToList();
            var userRole =await userManager.GetRolesAsync(user);

            List<RolAtaViewModel> rolAtaViewModels = new List<RolAtaViewModel>();
            foreach (var item in roles)
            {
                RolAtaViewModel model = new RolAtaViewModel();
                  model.RolID=item.Id;
                model.RolAdı = item.Name;
                model.Durum = userRole.Contains(item.Name);
                rolAtaViewModels.Add(model);
            }
            return View(rolAtaViewModels);
           
        }

        [HttpPost]
        [Route("RolAta/{id}")]      
        public async Task<IActionResult> RolAta(List<RolAtaViewModel> rolAtaViewModel)
        {
            var userID = (int)TempData["userID"];

            var user=await userManager.Users.FirstOrDefaultAsync(x=>x.Id==userID);
            foreach (var item in rolAtaViewModel)
            {
                if (item.Durum)
                {
                    await userManager.AddToRoleAsync(user, item.RolAdı);
                }
                else
                {
                    await userManager.RemoveFromRoleAsync(user, item.RolAdı);
                }
            }
            return RedirectToAction("KullanıcıListestesi");
        }
     
    }


}
