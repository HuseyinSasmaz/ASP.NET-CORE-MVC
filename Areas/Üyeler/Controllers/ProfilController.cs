using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Üyeler.Controllers
{
    [Area("Üyeler")]
    [AllowAnonymous]
    [Route("Üyeler/[controller]/[action]")]
    public class ProfilController : Controller
    {
        private readonly UserManager<UygulamaKullanıcısı> userManager;

        public ProfilController(UserManager<UygulamaKullanıcısı> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult>  Index()
        {
            try
            {
                var deger = await userManager.FindByNameAsync(User.Identity.Name);
                if (deger!=null)
                {
                    KullanıcıDüzenleViewModel p = new KullanıcıDüzenleViewModel();

                    p.adı = deger.Adı;
                    p.soyadı = deger.Soyadı;
                    p.email = deger.Email;
                    p.telefon = deger.PhoneNumber;

                    return View(p);
                }
                else
                {
                    return NotFound();
                }
               
            }
            catch (Exception ex)
            {
                var hata = "Bir hata oluştu" + ex.Message;
                return View(hata);    
            }
           
        }

       public async Task<IActionResult> Index(KullanıcıDüzenleViewModel p)
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            if (p.Resim!=null) 
            {
              var kaynak=Directory.GetCurrentDirectory();
                var eklenti = Path.GetExtension(p.Resim.FileName);
                var resimadı = Guid.NewGuid() + eklenti;
                var kayıtyeri =  Path.Combine(kaynak, "wwwroot", "kullanıcıresim", resimadı);
                using (var dosya = new FileStream(kayıtyeri, FileMode.Create))
                {
                    await p.Resim.CopyToAsync(dosya);
                } ;
                
                user.ResimYolu = resimadı;
                
            }

            user.Adı = p.adı;
            user.Soyadı=p.soyadı;
            user.Email = p.email;
            if (!string.IsNullOrEmpty(p.şifre))
            {
                user.PasswordHash = userManager.PasswordHasher.HashPassword(user, p.şifre);
            }
           
          var sonuc = await userManager.UpdateAsync(user);
            if (sonuc.Succeeded)
            {
                return RedirectToAction("GirişYap", "Giriş");
            }
            else
            {
                return View();
            }
           
        }
    }
}
