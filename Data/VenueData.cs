using _26_28sweNamelessBE.Models;

namespace _26_28sweNamelessBE.Data
{
    public class VenueData
    {
        public static List<Venue> Venues = new()
        {
            new() {  Id = 301, Name = "The Grand Arena", Address = "123 Main St", City = "New York City", State = "New York", Uid = "V4ZZtExf09dyP1GLH7Yhz7QqiOq2"},
            new() {  Id = 302, Name = "Sunset Pavilion", Address = "456 Sunset Blvd", City = "Los Angeles", State = "California", Uid = "ZpQoucFlCVNP5c0WunWKIi0mVKE3"},
            new() {  Id = 303, Name = "The Riverfront Stage", Address = "789 River Rd", City = "Chicago", State = "Illinois", Uid = "Yy2T2FeWvZdd4W8epNHt37AId6J2"},
            new() {  Id = 304, Name = "Mountain View Amphitheater", Address = "321 Mountain Ave", City = "Denver", State = "Colorado", Uid = "Yy2T2FeWvZdd4W8epNHt37AId6J2"},

        };
    }
}
