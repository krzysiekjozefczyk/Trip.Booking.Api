namespace Trips.Booking.Core.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string TripName { get; set; }
        public int TripId { get; set; }
        public int TravelersAmount { get; set; }
        public string StartDate { get; set; }
        public string Country { get; set; }
        public string TripDescription { get; set; }
    }
}
