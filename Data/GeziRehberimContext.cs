using GeziRehberim.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeziRehberim.Data
{
    public class GeziRehberimContext:IdentityDbContext<UygulamaKullanıcısı,UygulamaRolü,int>
    {
        public GeziRehberimContext(DbContextOptions options) : base(options)
        {

        }

        public  DbSet<AltÖzellik> AltÖzelliks { get; set; }
        public  DbSet<GidilecekYerler> GidilecekYerlers { get; set; }
        public  DbSet<HaberBülteni> HaberBültenis { get; set; }
        public  DbSet<Hakkımzda> Hakkımzdas { get; set; }
        public  DbSet<Hakkımzda2> Hakkımzda2s { get; set; }
        public  DbSet<İletisim> İletisims { get; set; }
        public  DbSet<Özellik> Özelliks { get; set; }
        public  DbSet<Özellik2> Özellik2s { get; set; }
        public  DbSet<Referanslar> Referanslars { get; set; }
        public  DbSet<Rehber> Rehbers { get; set; }
        public  DbSet<Yorumlar> Yorumlars { get; set; }
        public  DbSet<Rezervasyon> Rezervasyons { get; set; }
        public DbSet<BizeUlasın> BizeUlasıns { get;set;}
        public DbSet<Duyurular> Duyurulars { get;set;}
    }
}

