﻿using _26_28sweNamelessBE.Models;

namespace _26_28sweNamelessBE.DTOs
{
    public class CreateEventDTO
    {
        public string? Artist { get; set; }
        public int VenueId { get; set; }
        public DateTime Date { get; set; }
        public string? TicketUrl { get; set; }

        public decimal TicketPrice { get; set; }
    }
}