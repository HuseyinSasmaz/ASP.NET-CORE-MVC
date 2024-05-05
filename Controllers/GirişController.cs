using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Controllers
{
	[AllowAnonymous]
	public class GirişController : Controller
    {
		private readonly UserManager<UygulamaKullanıcısı> userManager;
		private readonly SignInManager<UygulamaKullanıcısı> signInManager;

        public GirişController(UserManager<UygulamaKullanıcısı> userManager, SignInManager<UygulamaKullanıcısı> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
		public IActionResult KayıtOl()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> KayıtOl(KullanıcıKayıtViewModel p)
		{
			UygulamaKullanıcısı uygulamaKullanıcısı = new UygulamaKullanıcısı()
			{
				Adı = p.İsim,
				Soyadı = p.Soyisim,
				UserName = p.KullanıcıAdı,
				Email = p.Mail
			};

			if (p.Şifre==p.ŞifreTekrarı)
			{
				var sonuc = await userManager.CreateAsync(uygulamaKullanıcısı, p.Şifre);

				if (sonuc.Succeeded)
				{
					return RedirectToAction("GirişYap");
				}
				else
				{
					foreach (var item in sonuc.Errors)
					{
						ModelState.AddModelError("", item.Description);
					}
				}
			}
			return View(p);
		}

		[HttpGet]
		public IActionResult GirişYap()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> GirişYap(KullanıcıGirişViewModel p)
        {
			if (ModelState.IsValid)
			{
				var deger = await signInManager.PasswordSignInAsync(p.kullanıcıadı, p.şifre, false,true);

				if (deger.Succeeded)
				{
					return RedirectToAction("Index", "GidilecekYerler", new {area="Üyeler"});
				}
				else
				{
					return RedirectToAction("GirişYap","Giriş");
				}
			}
            return View();
        }
    }
}
