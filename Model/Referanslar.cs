using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Referanslar
    {
        [Key]
        public int ReferansID { get; set; }
        public string? Müşteri { get; set; }
        public string? Yorum { get; set; }
        public string? MüşteriResim { get; set; }
        public bool Durum { get; set; }
    }
}
