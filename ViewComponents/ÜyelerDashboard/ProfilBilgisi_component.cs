using GeziRehberim.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.ÜyelerDashboard
{
    
    public class ProfilBilgisi_component:ViewComponent
    {
        private readonly UserManager<UygulamaKullanıcısı> userManager;

        public ProfilBilgisi_component(UserManager<UygulamaKullanıcısı> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var kullanıcı = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ad = kullanıcı.Adı + " " + kullanıcı.Soyadı;
            ViewBag.tlf = kullanıcı.PhoneNumber;
            ViewBag.mail = kullanıcı.Email;
            ViewBag.şehir = "Adana";
                
            return View();
        }
    }
}
