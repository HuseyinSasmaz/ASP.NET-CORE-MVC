using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.Default
{
    public class Referanslar_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public Referanslar_component(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            var deger = context.Referanslars.ToList();
            
            return View(deger);  
        }
    }
}
