namespace Models
{
    public class ChordModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Dictionary<int, int> Tab { get; set; } //String / Fret
    }
}