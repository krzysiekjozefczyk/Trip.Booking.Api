using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Trips.Booking.Core.Dtos
{
    public class TripDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public int TravelersAmount { get; set; }
        public string Country { get; set; }
    }
}
