using Castle.Core.Smtp;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace GeziRehberim.Controllers
{
    [AllowAnonymous]
    public class SifreİslemleriController : Controller
    {
        //private readonly Microsoft.AspNetCore.Identity.UserManager<UygulamaKullanıcısı> userManager;

        //public SifreİslemleriController(Microsoft.AspNetCore.Identity.UserManager<UygulamaKullanıcısı> userManager)
        //{
        //    this.userManager = userManager;
        //}

        private readonly Microsoft.AspNetCore.Identity. UserManager<UygulamaKullanıcısı> _userManager;
        

        public SifreİslemleriController(UserManager<UygulamaKullanıcısı> userManager)
        {
            _userManager = userManager;
            
        }

        public IActionResult SifremiUnuttum()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SifremiUnuttum(SifremiUnuttumViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
             
            var user=await _userManager.FindByEmailAsync(model.Mail);

            if (user==null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                ModelState.AddModelError(string.Empty, "Kullanıcı bulunamadı veya e-posta adresi onaylanmamış.");
                return View(model);

            }

            string sıfırlatoken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callbackUrl = Url.Action("YeniSifreGir", "Sifreİslemleri", new { userId = user.Id, token=sıfırlatoken },HttpContext.Request.Scheme);
            
            //var mesaj = new MimeMessage();
            //mesaj.From.Add(new MailboxAddress("Admin", "hozat01@gmail.com"));
            //mesaj.To.Add(new MailboxAddress("", model.Mail));
            //var builder = new BodyBuilder();
            //builder.TextBody = callbackUrl;
            //mesaj.Body = builder.ToMessageBody();
            //mesaj.Subject = "Şifre sıfırlama işlemi";
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Admin", "hozat01@gmail.com"));
            message.To.Add(new MailboxAddress("", model.Mail));
            message.Subject = "Şifre Sıfırlama İşlemi";
            message.Body = new TextPart("plain")
            {
                Text = "Şifrenizi sıfırlamak için lütfen aşağıdaki linke tıklayın:\n\n" + callbackUrl
            };
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {

                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("hozat01@gmail.com", "bcqk rpmt ajgt pvwl");
                await client.SendAsync(message);
                await client.DisconnectAsync(true);

                return View();
            }
            return View();
        }
        public IActionResult YeniSifreGir(string userId, string token)
        {
            //var model = new YeniSifreViewModel { UserId = userId, Token = token };
            TempData["userId"] = userId;
            TempData["token"] = token;
            return View();  
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YeniSifreGir(YeniSifreViewModel model)
        {
            var userId = TempData["userId"]?.ToString();
            var token = TempData["token"]?.ToString();
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(token))
            {
                return BadRequest("Geçersiz kullanıcı kimliği veya token.");
            }
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                return BadRequest("Kullanıcı bulunamadı.");
            }
            var result = await _userManager.ResetPasswordAsync(user, token.ToString(), model.YeniSifre);
           
               
                if (result.Succeeded)
                {
                    return RedirectToAction("GirişYap", "Giriş");
                }
            

            foreach (var error in result.Errors )
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }           
            return View(model); 
        }
    }
}
