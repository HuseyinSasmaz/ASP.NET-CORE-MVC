namespace GeziRehberim.Model
{
    public class KullanıcıDüzenleViewModel
    {
        public string? adı { get; set; }
        public string? soyadı { get; set; }
        public string? şifre { get; set; }
        public string? şifretekrarı { get; set; }
        public string? email { get; set; }
        public string? telefon { get; set; }
        public string? resimURL { get; set; }
        public IFormFile? Resim { get; set; }
    }
}
