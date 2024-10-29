using _26_28sweNamelessBE.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using _26_28sweNamelessBE.DTOs;
namespace _26_28sweNamelessBE.API
{
    public class EventAPI
    {
        public static void Map(WebApplication app)
        {
            // Get All Events + RSVP
            app.MapGet("/events", async (_26_28sweNamelessBEDbContext db) =>
            {

                var events = await db.Events
                .Include(e=> e.Venue)
                .OrderBy(e => e.Date)
                .ToListAsync();

                return Results.Ok(events);

            });

            app.MapGet("/events/users/{uid}", async (_26_28sweNamelessBEDbContext db, string uid) =>
            {
                var userEvents = await db.Events
                    .Include(e => e.RSVP)
                    .Include(e => e.Venue)
                    .Where(e => e.Uid == uid)
                    .OrderBy(e => e.Date)
                    .ToListAsync();

                // Return an empty array with 200 OK if no events are found
                return Results.Ok(userEvents);
            });

            // Get Single Event
            app.MapGet("/events/{id}", (_26_28sweNamelessBEDbContext db, int id) =>
            {
                var eventId = db.Events
                .Include(e => e.RSVP)
                .Include(e => e.Venue)
                .FirstOrDefault(a => a.Id == id);


                if (eventId == null)
                {
                    return Results.NotFound("No Event Found.");
                }

                return Results.Ok(eventId);
            });

            // Create Event
            app.MapPost("/events", (_26_28sweNamelessBEDbContext db, CreateEventDTO eventDTO) =>
            {
                var newEvent = new Event
                {
                    Date = eventDTO.Date,
                    Artist = eventDTO.Artist,
                    VenueId = eventDTO.VenueId,
                    TicketUrl = eventDTO.TicketUrl,
                    TicketPrice = eventDTO.TicketPrice,
                };

                db.Events.Add(newEvent);
                db.SaveChanges();

                return Results.Created($"/events/{newEvent.Id}", newEvent);
            });

            // Update Event
            app.MapPut("/events/{id}", (_26_28sweNamelessBEDbContext db, int id, UpdateEventDTO eventDTO) =>
            {
                var eventToUpdate = db.Events.Include(b => b.Venue).FirstOrDefault(b => b.Id == id);
                if (eventToUpdate == null)
                {
                    return Results.NotFound("Event not found");
                }


                eventToUpdate.Date = eventDTO.Date;
                eventToUpdate.Artist = eventDTO.Artist;
                eventToUpdate.VenueId = eventDTO.VenueId;
                eventToUpdate.TicketUrl = eventDTO.TicketUrl;
                eventToUpdate.TicketPrice = eventDTO.TicketPrice;

                try
                {
                    db.SaveChanges();
                    return Results.Ok(eventToUpdate);
                }
                catch (DbUpdateException)
                {
                    return Results.BadRequest("Error occurred updating event");
                }
            });

            // Delete Event
            app.MapDelete("/events/{id}", (_26_28sweNamelessBEDbContext db, int id) =>
            {

                var events = db.Events.FirstOrDefault(b => b.Id == id);

                if (events == null)
                {
                    return Results.NotFound("event is null");
                }

                db.Events.Remove(events);
                db.SaveChanges();
                return Results.Ok("event deleted");

            });

        }

    }
}
