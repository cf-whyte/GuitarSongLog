using Classes;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class SongModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public List<Chord> Chords { get; set; }
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;
    }
}