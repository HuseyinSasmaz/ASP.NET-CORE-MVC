using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.AdminDashboard
{
    public class Chart1İstatistik:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public Chart1İstatistik(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke() 
        { 
            ViewBag.v1=context.GidilecekYerlers.Count();
            ViewBag.v2=context.Users.Count();

            return View();
        } 
    }
}
