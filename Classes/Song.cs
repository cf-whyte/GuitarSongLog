namespace Classes
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public List<Chord> Chords { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
    }
}