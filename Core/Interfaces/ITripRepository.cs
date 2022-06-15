using Trips.Booking.Core.Dtos;
using Trips.Booking.Core.Entities;

namespace Trips.Booking.Core.Interfaces
{
    public interface ITripRepository
    {
        Task<Trip> GetTripByIdAsync(int id);
        Task<IReadOnlyList<Trip>> GetTripsAsync();
        Task CreateTripAsync(TripDto model);
        Task UpdateTripAsync(int id, TripDto trip);
        Task DeleteTripAsync(int id);
    }
}
