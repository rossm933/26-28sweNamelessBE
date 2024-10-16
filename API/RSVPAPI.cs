using Microsoft.EntityFrameworkCore;
using _26_28sweNamelessBE.Models;

namespace _26_28sweNamelessBE.API
{
    public class RSVPAPI
    {
        public static void Map(WebApplication app)
        {
            app.MapGet("/rsvps/user/{uid}", (_26_28sweNamelessBEDbContext db, string uid) =>
            {
                var rsvp = db.RSVPs
                            .Where(rsvp => rsvp.Uid == uid)
                            .OrderBy(rsvp => rsvp.Event.Date)
                            .Include(rsvp => rsvp.Event)
                            .Select(rsvp => new
                            {
                                rsvp.Id,
                                rsvp.EventId,
                                rsvp.Event,
                            });

                if (rsvp == null)
                {
                    return Results.NotFound();
                }

                return Results.Ok(rsvp);
            });

            app.MapPost("/rsvps", (_26_28sweNamelessBEDbContext db, RSVP newRSVP) =>
            {
                RSVP rsvp = new()
                {
                    Id = newRSVP.Id,
                    EventId = newRSVP.EventId,
                    Uid = newRSVP.Uid,
                };

                db.RSVPs.Add(rsvp);
                db.SaveChanges();
                return Results.Created($"/rsvps/{rsvp.Id}", new
                {
                    rsvp.Id,
                    rsvp.EventId,
                });
            });

            app.MapDelete("/rsvps/{id}", (_26_28sweNamelessBEDbContext db, int id) =>
            {
                RSVP rsvp = db.RSVPs.SingleOrDefault(rsvp => rsvp.Id == id);

                if (rsvp == null)
                {
                    return Results.NotFound();
                }

                db.RSVPs.Remove(rsvp);
                db.SaveChanges();
                return Results.NoContent();
            });
        }
    }
}
