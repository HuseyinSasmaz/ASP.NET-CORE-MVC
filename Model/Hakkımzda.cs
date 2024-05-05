using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Hakkımzda
    {
        [Key]
        public int HakkımzdaID { get; set; }
        public string? Baslık { get; set; }
        public string? Acıklama { get; set; }
        public string? Baslık2 { get; set; }
        public string? Acıklama2 { get; set; }
        public string? Resim { get; set; }
        public bool Durum { get; set; }
    }
}
