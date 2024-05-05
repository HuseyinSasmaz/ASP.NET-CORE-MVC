using System.ComponentModel.DataAnnotations;

namespace GeziRehberim.Model
{
    public class HaberBülteni
    {
        [Key]
        public int HaberBülteniID { get; set; }
        public string? Mail { get; set; }
    }
}
