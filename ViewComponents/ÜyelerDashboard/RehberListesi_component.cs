using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.ÜyelerDashboard
{
    public class RehberListesi_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public RehberListesi_component(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var deger = context.Rehbers.ToList();
            return View(deger);
        }
    }
}
