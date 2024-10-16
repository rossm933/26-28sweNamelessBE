using Microsoft.EntityFrameworkCore;
using _26_28sweNamelessBE.Models;

namespace _26_28sweNamelessBE.API
{
    public class VenueAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/venues", (_26_28sweNamelessBEDbContext db) =>
            {
                return db.Venues
                .OrderBy(venue => venue.Name)
                .Select(venue => new
                {
                    venue.Id,
                    venue.Name,
                    venue.Address,
                    venue.City,
                    venue.State,
                    Events = venue.Events
                        .OrderByDescending(e => e.Date)
                        .Select(e => new
                        {
                            e.Id,
                            e.Date,
                            e.Artist,
                            e.TicketPrice,
                            e.TicketUrl,
                        }),
                });
            });

            app.MapGet("/venues/users/{uid}", (_26_28sweNamelessBEDbContext db, string uid) =>
            {
                return db.Venues
                .OrderBy(venue => venue.Name)
                .Where(venue => venue.Uid == uid)
                .Select(venue => new
                {
                    venue.Id,
                    venue.Name,
                    venue.Address,
                    venue.City,
                    venue.State,
                    Events = venue.Events
                        .OrderByDescending(e => e.Date)
                        .Select(e => new
                        {
                            e.Id,
                            e.Date,
                            e.Artist,
                            e.TicketPrice,
                            e.TicketUrl,
                        }),
                });
            });

            app.MapGet("/venues/{id}", (_26_28sweNamelessBEDbContext db, int id) =>
            {
                Venue venue = db.Venues
                            .Include(venue => venue.Events)
                            .SingleOrDefault(venue => venue.Id == id);

                if (venue == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(new
                {
                    venue.Id,
                    venue.Name,
                    venue.Address,
                    venue.City,
                    venue.State,
                    Events = venue.Events
                        .OrderByDescending(e => e.Date)
                        .Select(e => new
                        {
                            e.Id,
                            e.Date,
                            e.Artist,
                            e.TicketPrice,
                            e.TicketUrl,
                        }),
                });
            });

            app.MapPost("/venues", (_26_28sweNamelessBEDbContext db, Venue newVenue) =>
            {
                Venue venue = new()
                {
                    Name = newVenue.Name,
                    Address = newVenue.Address,
                    City = newVenue.City,
                    State = newVenue.State,
                    Uid = newVenue.Uid,
                };

                db.Venues.Add(venue);
                db.SaveChanges();
                return Results.Created($"/venues/{venue.Id}", new
                {
                    venue.Id,
                    venue.Name,
                    venue.Address,
                    venue.City,
                    venue.State,
                });
            });

            app.MapPut("/venues/{id}", (_26_28sweNamelessBEDbContext db, int id, Venue venue) =>
            {
                Venue venueToUpdate = db.Venues.SingleOrDefault(venue => venue.Id == id);

                if (venueToUpdate == null)
                {
                    return Results.NotFound();
                }

                venueToUpdate.Name = venue.Name;
                venueToUpdate.Address = venue.Address;
                venueToUpdate.City = venue.City;
                venueToUpdate.State = venue.State;
                venueToUpdate.Uid = venue.Uid;

                db.SaveChanges();
                return Results.Ok(new
                {
                    venue.Id,
                    venue.Name,
                    venue.Address,
                    venue.City,
                    venue.State,
                });

            });

            app.MapDelete("/venues/{id}", (_26_28sweNamelessBEDbContext db, int id) =>
            {
                Venue venue = db.Venues.SingleOrDefault(venue => venue.Id == id);

                if (venue == null)
                {
                    return Results.NotFound();
                }

                db.Venues.Remove(venue);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
