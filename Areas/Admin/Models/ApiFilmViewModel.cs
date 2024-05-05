namespace GeziRehberim.Areas.Admin.Models
{
    public class ApiFilmViewModel
    {
        //public int Sıralama { get; set; }
        //public string? Baslık { get; set; }
        //public string? Resim { get; set; }
        //public double Puanı { get; set; }
        //public int Yıl { get; set; }
        //public string? Fragman { get; set; }

        public int Rank { get; set; }
        public string? Title { get; set; }
        public string? Thumbnail { get; set; }
        public double Rating { get; set; } 
        public int Year { get; set; }
        public string Trailer { get; set; }
    }
}
