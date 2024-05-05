using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class YeniSifreViewModel
    {

       
        [Required(ErrorMessage = "Lütfen yeni şifrenizi giriniz..!")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
        ErrorMessage = "Şifre en az bir büyük harf, bir küçük harf, bir rakam ve bir özel karakter içermelidir.")]
        public string YeniSifre { get; set; }
        [Required(ErrorMessage = "Lütfen  şifrenizi tekrar giriniz..!  ")]
        [Compare("YeniSifreTekrarı",ErrorMessage ="Şifreler Eşleşmiyor..!")]
        public string YeniSifreTekrarı { get; set; }

    }
}
