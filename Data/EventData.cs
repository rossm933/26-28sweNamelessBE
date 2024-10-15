using _26_28sweNamelessBE.Models;
namespace _26_28sweNamelessBE.Data
{
    public class EventData
    {
        public static List<Event> Events = new()
        {
            new() {Id = 101, Date = new DateTime(2024, 11, 18), Artist = "The Rolling Waves", VenueId = 301, TicketUrl = "https://example.com/tickets/rolling-waves", TicketPrice = 65.50m, Uid = "V4ZZtExf09dyP1GLH7Yhz7QqiOq2"},
            new() {Id = 102, Date = new DateTime(2024, 12, 4), Artist = "Electric Dreams", VenueId = 302,TicketUrl = "https://example.com/tickets/electric-dreams",TicketPrice = 80.00m, Uid = "ZpQoucFlCVNP5c0WunWKIi0mVKE3"},
            new() {Id = 103, Date = new DateTime(2024, 12, 14), Artist = "The Jazz Collective", VenueId = 303, TicketUrl = "https://example.com/tickets/jazz-collective", TicketPrice = 50.00m, Uid = "Yy2T2FeWvZdd4W8epNHt37AId6J2"},
            new() {Id = 104, Date = new DateTime(2024, 11, 10), Artist = "Symphony of Stars", VenueId = 301, TicketUrl = "https://example.com/tickets/symphony-stars", TicketPrice = 95.75m, Uid = "Yy2T2FeWvZdd4W8epNHt37AId6J2"},
            new() {Id = 105, Date = new DateTime(2024, 10, 23), Artist = "Rock Legends", VenueId = 302, TicketUrl = "https://example.com/tickets/rock-legends", TicketPrice = 120.00m, Uid = "ZpQoucFlCVNP5c0WunWKIi0mVKE3"},
            new() {Id = 106, Date = new DateTime(2024, 10, 25), Artist = "Future Sounds", VenueId = 304, TicketUrl = "https://example.com/tickets/future-sounds", TicketPrice = 75.99m, Uid = "V4ZZtExf09dyP1GLH7Yhz7QqiOq2"},
        };
    }
}
