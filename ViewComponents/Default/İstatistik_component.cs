using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.Default
{
    public class İstatistik_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public İstatistik_component(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
