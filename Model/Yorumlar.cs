using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeziRehberim.Model
{
    public class Yorumlar
    {
        [Key]
        public int YorumID { get; set; }
        public string? KullanıcıYorum { get; set; }
        public DateTime YorumTarihi { get; set; }
        public string? Yorumİçerik { get; set; }
        public bool Durum { get; set; }
        public int GidilecekYerlerID { get; set; }
        public GidilecekYerler GidilecekYerler { get; set; }
        [ForeignKey("UygulamaKullanıcısı")]
        public int UygulamaKullanıcısıID { get; set; }
        public UygulamaKullanıcısı UygulamaKullanıcısı { get; set; }
       
    }
}
