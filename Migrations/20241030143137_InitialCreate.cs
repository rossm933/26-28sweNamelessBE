using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace _26_28sweNamelessBE.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    State = table.Column<string>(type: "text", nullable: true),
                    Uid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Artist = table.Column<string>(type: "text", nullable: true),
                    VenueId = table.Column<int>(type: "integer", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: true),
                    TicketUrl = table.Column<string>(type: "text", nullable: true),
                    TicketPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSVPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventId = table.Column<int>(type: "integer", nullable: false),
                    Uid = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSVPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RSVPs_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "Id", "Address", "City", "Name", "State", "Uid" },
                values: new object[,]
                {
                    { 301, "123 Main St", "New York City", "The Grand Arena", "New York", "V4ZZtExf09dyP1GLH7Yhz7QqiOq2" },
                    { 302, "456 Sunset Blvd", "Los Angeles", "Sunset Pavilion", "California", "ZpQoucFlCVNP5c0WunWKIi0mVKE3" },
                    { 303, "789 River Rd", "Chicago", "The Riverfront Stage", "Illinois", "Yy2T2FeWvZdd4W8epNHt37AId6J2" },
                    { 304, "321 Mountain Ave", "Denver", "Mountain View Amphitheater", "Colorado", "Yy2T2FeWvZdd4W8epNHt37AId6J2" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Artist", "Date", "ImageUrl", "TicketPrice", "TicketUrl", "Uid", "VenueId" },
                values: new object[,]
                {
                    { 101, "The Rolling Waves", new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img.freepik.com/premium-photo/rear-view-silhouette-group-people-watching-music-concert-with-different-lights_1004086-165.jpg", 65.50m, "https://example.com/tickets/rolling-waves", "V4ZZtExf09dyP1GLH7Yhz7QqiOq2", 301 },
                    { 102, "Electric Dreams", new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.stagespot.com/media/wysiwyg/587293828-stage-lighting-wallpaper.jpg", 80.00m, "https://example.com/tickets/electric-dreams", "ZpQoucFlCVNP5c0WunWKIi0mVKE3", 302 },
                    { 103, "The Jazz Collective", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEiovrj7xRN01ZmE-GGTHwHg1a6lmqN1KoSJHPr6yWomExfjIcnQpawXUd2C3NuY_1Dj9GfXUW2lsgkwYFZBfNSZ2X5qKExfZuSh0BbfOTYEMrHhclOKCHoo6BD1NMnqUJBJmQp4JES3qpo/s1600/Edit_Scary_Little_Friends_0035.JPG", 50.00m, "https://example.com/tickets/jazz-collective", "Yy2T2FeWvZdd4W8epNHt37AId6J2", 303 },
                    { 104, "Symphony of Stars", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://cdn.britannica.com/58/155258-050-2F8189A9/Symphony-concert-Svetlanov-Hall-Moscow-International-House.jpg", 95.75m, "https://example.com/tickets/symphony-stars", "Yy2T2FeWvZdd4W8epNHt37AId6J2", 301 },
                    { 105, "Rock Legends", new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://img.freepik.com/premium-photo/crowded-place-group-different-people-attending-live-concert-having-fun-singling-listening-music_489646-25884.jpg", 120.00m, "https://example.com/tickets/rock-legends", "ZpQoucFlCVNP5c0WunWKIi0mVKE3", 302 },
                    { 106, "Future Sounds", new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://upload.wikimedia.org/wikipedia/commons/c/cb/Classical_spectacular10.jpg", 75.99m, "https://example.com/tickets/future-sounds", "V4ZZtExf09dyP1GLH7Yhz7QqiOq2", 304 }
                });

            migrationBuilder.InsertData(
                table: "RSVPs",
                columns: new[] { "Id", "EventId", "Uid" },
                values: new object[,]
                {
                    { 1, 101, "V4ZZtExf09dyP1GLH7Yhz7QqiOq2" },
                    { 2, 102, "ZpQoucFlCVNP5c0WunWKIi0mVKE3" },
                    { 3, 103, "Yy2T2FeWvZdd4W8epNHt37AId6J2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_VenueId",
                table: "Events",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_RSVPs_EventId",
                table: "RSVPs",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RSVPs");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}
