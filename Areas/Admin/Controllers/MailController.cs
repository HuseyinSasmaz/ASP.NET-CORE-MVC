using GeziRehberim.Model;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MailKit.Net.Smtp;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace GeziRehberim.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]    
    public class MailController : Controller
    {
        private readonly SignInManager<UygulamaKullanıcısı> signInManager;

        public MailController(SignInManager<UygulamaKullanıcısı> signInManager)
        {
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult MailGönder()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MailGönder(Mailİstek mailİstek)
        {
            //var user = await signInManager.UserManager.GetUserAsync(User);

           // mailİstek.GönderenMail = user.Email;
            var mesaj = new MimeMessage();
            mesaj.From.Add(new MailboxAddress("Admin", "hozat01@gmail.com"));
            mesaj.To.Add(new MailboxAddress("",mailİstek.AlanMail));

            var builder = new BodyBuilder();
            builder.TextBody = mailİstek.İçerik;
            mesaj.Body = builder.ToMessageBody();
            mesaj.Subject = mailİstek.Baslık;

            using(var client =new MailKit.Net.Smtp.SmtpClient())
            {
            
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("hozat01@gmail.com", "bcqk rpmt ajgt pvwl");
                await client.SendAsync(mesaj);
                await client.DisconnectAsync(true);
                
                return View();
            } 
        }
    }
}
