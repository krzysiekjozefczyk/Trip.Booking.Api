using Trips.Booking.Core.Entities;

namespace Trips.Booking.Core.Interfaces
{
    public interface ITripRepository
    {
        Task<Trip> GetTripByIdAsync(int id);
        Task<IReadOnlyList<Trip>> GetTripsAsync();
    }
}
