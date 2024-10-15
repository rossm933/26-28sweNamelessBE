namespace _26_28sweNamelessBE.Models
{
    public class Venue
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }

        public List<Event>? Events { get; set; }

        public string? Uid { get; set; }

    }
}
