using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Rezervasyon
    {
        [Key]
        public int RezervasyonID { get; set; }
        public int UygulamaKullanıcısıId { get; set; }
        public UygulamaKullanıcısı UygulamaKullanıcısı  { get; set; }
        public int GidilecekYerlerID { get; set; }
        public GidilecekYerler GidilecekYerler { get; set; }
        public string? KişiSayısı { get; set; }
        public DateTime RezervasyonTarihi { get; set; }
        public string? Açıklama { get; set; }
        public string? Statu { get; set; }
    }
}
