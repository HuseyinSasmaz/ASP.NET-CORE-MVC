using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class GidilecekYerler
    {
        [Key]
        public int GidilecekYerlerID { get; set; }
        public string? Şehir { get; set; }
        public string? GündüzGece { get; set; }
        public double Fiyat { get; set; }
        public string? Resim { get; set; }
        public string? Açıklama { get; set; }
        public int Kapasite { get; set; }
        public bool Durum { get; set; }
        public string? KapakResmi { get; set; }
        public string? Resim1 { get; set; }
        public string? Detay1 { get; set; }
        public string? Detay2 { get; set; }
        public List<Yorumlar> Yorumlars { get; set; }
        public List<Rezervasyon> Rezervasyons { get; set; }
        public int RehberID { get; set; }
        public Rehber Rehber { get; set; }
    }
}
