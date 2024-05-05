using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class AltÖzellik
    {
        [Key]
        public int AltÖzellikID { get; set; }
        public string? Başlık { get; set; }
        public string? Açıklama { get; set; }
    }
}
