using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.ÜyelerDashboard
{
    public class SonRotalar_component : ViewComponent
    {
        private readonly GeziRehberimContext context;

        public SonRotalar_component(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
           var deger=context.GidilecekYerlers.Take(4).OrderByDescending(x=>x.GidilecekYerlerID).ToList();
            return View(deger);
        }
    }
}
