using GeziRehberim.Data;
using GeziRehberim.Model;
using Microsoft.AspNetCore.Mvc;

namespace GeziRehberim.ViewComponents.Default
{
    public class Özellik_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public Özellik_component(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
            
           List<Özellik> data=context.Özelliks.Select(veri=>new Özellik
           {
               Resim=veri.Resim,
               Başlık=veri.Başlık,
               Detaylar=veri.Detaylar  
           }).ToList(); 
          
            return View(data);
        }
    }
}
