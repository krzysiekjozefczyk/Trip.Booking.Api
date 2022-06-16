using System.ComponentModel.DataAnnotations;

namespace Trips.Booking.Core.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int TravelersAmount { get; set; }
        [Required]
        public string Email { get; set; }[Required]
        public Trip Trip { get; set; }  
        public int TripId { get; set; }
    }
}
