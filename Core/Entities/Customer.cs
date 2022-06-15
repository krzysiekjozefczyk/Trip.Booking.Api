using System.ComponentModel.DataAnnotations;

namespace Trips.Booking.Core.Entities
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Trip Trip { get; set; }  
        public int TripId { get; set; }
    }
}
