using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.Default
{
    public class PopülerYerler_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public PopülerYerler_component(GeziRehberimContext context)
        {
            this.context = context;     
        }

        public IViewComponentResult Invoke()
        {
            var deger = context.GidilecekYerlers.ToList();
            return View(deger);
        }
    }
}
