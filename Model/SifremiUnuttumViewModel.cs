using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class SifremiUnuttumViewModel
    {
        [Required(ErrorMessage = "E-posta adresi gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Mail { get; set; }
    }
}
