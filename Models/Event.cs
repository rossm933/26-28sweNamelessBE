namespace _26_28sweNamelessBE.Models
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Artist { get; set; }
        public int VenueId { get; set; }

        public Venue? Venue { get; set; }
        public string? TicketUrl { get; set; }

        public decimal TicketPrice { get; set; }

        public string? Uid { get; set; }

        public List<RSVP>? RSVP { get; set; }

    }
}
