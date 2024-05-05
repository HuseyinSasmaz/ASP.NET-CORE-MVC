using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Özellik2
    {
        [Key]
        public int Özellik2ID { get; set; }
        public string? Başlık { get; set; }
        public string? Detaylar { get; set; }
        public string? Resim { get; set; }
        public bool Durum { get; set; }
    }
}
