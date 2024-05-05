using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Özellik
    {
        [Key]
        public int ÖzellikID { get; set; }
        public string? Başlık { get; set; }
        public string? Detaylar { get; set; }
        public string? Resim { get; set; }
        public bool Durum { get; set; }
    }
}
