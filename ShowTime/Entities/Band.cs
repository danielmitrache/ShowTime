using ShowTime.Enums;

namespace ShowTime.Entities
{
    public class Band
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Genre Genre { get; set; }
        public ICollection<FestivalBand>? FestivalBands { get; set; } = [];
    }
}
