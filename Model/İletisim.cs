using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class İletisim
    {
        [Key]
        public int İletisimID { get; set; }
        public string? Acıklama { get; set; }
        public string? Mail { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }
        public string? HaritaLokasyon { get; set; }
        public bool Durum { get; set; }
    }
}
