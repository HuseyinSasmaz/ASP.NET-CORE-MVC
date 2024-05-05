

using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
	public class KullanıcıKayıtViewModel
	{
		[Required(ErrorMessage="Lütfen adınızı giriniz")]
		public string? İsim { get; set; }

		[Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
		public string? Soyisim { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
		public string? KullanıcıAdı { get; set; }

		[Required(ErrorMessage = "Lütfen mail adresinizi giriniz")]
		[EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
		public string? Mail { get; set; }

		[Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
		public string? Şifre { get; set; }

		[Required(ErrorMessage = "Lütfen şifre tekrarı")]
		[Compare("Şifre",ErrorMessage ="Şifreler uyumlu değil")]
		public string? ŞifreTekrarı { get; set; }
	}
}
