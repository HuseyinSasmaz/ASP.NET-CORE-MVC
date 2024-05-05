using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Areas.Üyeler.Controllers
{
    [Area("Üyeler")]
    [AllowAnonymous]
    public class MesajlarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
