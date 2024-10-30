using _26_28sweNamelessBE.Models;
namespace _26_28sweNamelessBE.Data
{
    public class EventData
    {
        public static List<Event> Events = new()
        {
            new() {Id = 101, Date = new DateTime(2024, 11, 18), Artist = "The Rolling Waves", VenueId = 301, TicketUrl = "https://example.com/tickets/rolling-waves", TicketPrice = 65.50m, Uid = "V4ZZtExf09dyP1GLH7Yhz7QqiOq2", ImageUrl="https://img.freepik.com/premium-photo/rear-view-silhouette-group-people-watching-music-concert-with-different-lights_1004086-165.jpg"},
            new() {Id = 102, Date = new DateTime(2024, 12, 4), Artist = "Electric Dreams", VenueId = 302,TicketUrl = "https://example.com/tickets/electric-dreams",TicketPrice = 80.00m, Uid = "ZpQoucFlCVNP5c0WunWKIi0mVKE3", ImageUrl="https://www.stagespot.com/media/wysiwyg/587293828-stage-lighting-wallpaper.jpg"},
            new() {Id = 103, Date = new DateTime(2024, 12, 14), Artist = "The Jazz Collective", VenueId = 303, TicketUrl = "https://example.com/tickets/jazz-collective", TicketPrice = 50.00m, Uid = "Yy2T2FeWvZdd4W8epNHt37AId6J2", ImageUrl="https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiovrj7xRN01ZmE-GGTHwHg1a6lmqN1KoSJHPr6yWomExfjIcnQpawXUd2C3NuY_1Dj9GfXUW2lsgkwYFZBfNSZ2X5qKExfZuSh0BbfOTYEMrHhclOKCHoo6BD1NMnqUJBJmQp4JES3qpo/s1600/Edit_Scary_Little_Friends_0035.JPG"},
            new() {Id = 104, Date = new DateTime(2024, 11, 10), Artist = "Symphony of Stars", VenueId = 301, TicketUrl = "https://example.com/tickets/symphony-stars", TicketPrice = 95.75m, Uid = "Yy2T2FeWvZdd4W8epNHt37AId6J2", ImageUrl="https://cdn.britannica.com/58/155258-050-2F8189A9/Symphony-concert-Svetlanov-Hall-Moscow-International-House.jpg"},
            new() {Id = 105, Date = new DateTime(2024, 10, 23), Artist = "Rock Legends", VenueId = 302, TicketUrl = "https://example.com/tickets/rock-legends", TicketPrice = 120.00m, Uid = "ZpQoucFlCVNP5c0WunWKIi0mVKE3", ImageUrl="https://img.freepik.com/premium-photo/crowded-place-group-different-people-attending-live-concert-having-fun-singling-listening-music_489646-25884.jpg"},
            new() {Id = 106, Date = new DateTime(2024, 10, 25), Artist = "Future Sounds", VenueId = 304, TicketUrl = "https://example.com/tickets/future-sounds", TicketPrice = 75.99m, Uid = "V4ZZtExf09dyP1GLH7Yhz7QqiOq2", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/c/cb/Classical_spectacular10.jpg"},
        };
    }
}
