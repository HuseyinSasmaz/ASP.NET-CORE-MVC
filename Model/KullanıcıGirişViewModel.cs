using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class KullanıcıGirişViewModel
    {
        [Required(ErrorMessage ="Kullanıcı adını giriniz.!")]
        public string? kullanıcıadı { get; set; }

        [Required(ErrorMessage ="Şifrenizi giriniz.!")]
        public string? şifre { get; set; }
    }
}
