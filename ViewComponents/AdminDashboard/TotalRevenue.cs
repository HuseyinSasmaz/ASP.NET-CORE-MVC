using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.AdminDashboard
{
    
    public class TotalRevenue:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
