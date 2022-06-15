using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Trips.Booking.Core.Entities
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int TravelersAmount { get; set; }
        public string Country{ get; set; }
    }
}
