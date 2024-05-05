using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.AdminDashboard
{
    public class DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}