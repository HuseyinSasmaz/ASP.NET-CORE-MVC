using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Controllers
{
    [AllowAnonymous]  
    public class HataSayfasıController : Controller
    {
        public IActionResult Hata404(int code)
        {
            return View();
        }
    }
}
