using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Trips.Booking.Core.Entities
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        [Required]
        public string Country{ get; set; }
    }
}
