using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.Default
{
    public class Slider_component:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
