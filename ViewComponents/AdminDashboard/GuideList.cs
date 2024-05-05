using Microsoft.AspNetCore.Mvc;
namespace GeziRehberim.ViewComponents.AdminDashboard
{
    public class GuideList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
