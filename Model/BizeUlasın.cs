namespace GeziRehberim.Model
{
    public class BizeUlasın
    {

        public int BizeUlasınID { get; set; }
        public string? İsim { get; set; }
        public string? MailAdresi { get; set; }
        public string? Baslık { get; set; }
        public string? Mesaj { get; set; }
        public DateTime MesajTarihi { get; set; }
        public bool Durum { get; set; }
    }
}
