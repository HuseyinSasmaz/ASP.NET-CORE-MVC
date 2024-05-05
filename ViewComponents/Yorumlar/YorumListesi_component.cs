using GeziRehberim.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeziRehberim.ViewComponents.Yorumlar
{
    public class YorumListesi_component:ViewComponent
    {
        private readonly GeziRehberimContext context;

        public YorumListesi_component(GeziRehberimContext context)
        {
            this.context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.yorumsayısı = context.Yorumlars.Where(x => x.GidilecekYerlerID == id).Count();
            var deger = context.Yorumlars.Where(x=>x.GidilecekYerlerID==id).Include(x=>x.UygulamaKullanıcısı).ToList();
           
            return View(deger);  
        }
        

    }
}
