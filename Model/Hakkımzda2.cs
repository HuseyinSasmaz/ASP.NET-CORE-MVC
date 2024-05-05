using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Hakkımzda2
    {
        [Key]
        public int Hakkımızda2ID { get; set; }
        public string Baslık1 { get; set; }
        public string Baslık2 { get; set; }
        public string Acıklama { get; set; }
        public string Resim { get; set; }
    }
}
