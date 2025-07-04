namespace ShowTime.Entities
{
    public class FestivalBand
    {
        public Guid FestivalId { get; set; }
        public Guid BandId { get; set; }
        public Festival Festival { get; set; } = null!;
        public Band Band { get; set; } = null!;
        public int? Order { get; set; }
        public int? Day { get; set; }
    }
}
