using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class Rehber
    {
       

            [Key]
            public int RehberID { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [MaxLength(50, ErrorMessage = "Ad alanı en fazla 50 karakter olmalıdır.")]
        public string Adı { get; set; }
       
        [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
        [MinLength(10, ErrorMessage = "Açıklama alanı en az 10 karakter olmalıdır.")]
        public string Acıklama { get; set; }
        [Required(ErrorMessage = "Açıklama alanı zorunludur.")]
        [MinLength(10, ErrorMessage = "Açıklama alanı en az 20 karakter olmalıdır.")]
        public string Acıklama2 { get; set; }
       
        [Required(ErrorMessage = "Resim alanı zorunludur.")]
        public string Resim { get; set; }

            public string TwitterURL { get; set; }
            public string InstagramURL { get; set; }
            public bool Durum { get; set; }
        public List<GidilecekYerler> GidilecekYerlers { get; set; }


    }
}
