using Microsoft.AspNetCore.Identity;

namespace GeziRehberim.Model
{
    public class UygulamaKullanıcısı: IdentityUser<int>
    {
        public string? ResimYolu { get; set; }
        public string? Adı { get; set; }
        public string? Soyadı { get; set; }
        public string? Cinsiyet { get; set; }
        public List<Rezervasyon> Rezervasyons { get; set; }
        public List<Yorumlar> Yorumlars { get; set; }
    }
}
