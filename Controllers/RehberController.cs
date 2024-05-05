using GeziRehberim.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.Controllers
{
    [AllowAnonymous]
    public class RehberController : Controller
    {
        private readonly GeziRehberimContext context;

        public RehberController(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var deger = context.Rehbers.ToList();
            return View(deger);
        }
    }
}
