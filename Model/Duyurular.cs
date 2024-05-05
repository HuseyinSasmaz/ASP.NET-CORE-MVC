using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Duyurular
    {
        [Key]
        public int DuyuruID { get; set; }
        public string Baslık { get; set; }
        public string İcerik { get; set; }
       public DateTime Tarih { get; set; }
    }
}
