using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;


namespace GeziRehberim.ViewComponents.Default
{
    public class AltÖzellik_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public AltÖzellik_component(GeziRehberimContext context)
        {
            this.context = context;         
        }

        public IViewComponentResult Invoke()
        {
            var deger = context.AltÖzelliks.ToList();
            return View(deger);
        }
    }
}
