using Microsoft.EntityFrameworkCore;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;

namespace Trips.Booking.Infrastructure.Data
{
    public class TripRepository : ITripRepository
    {
        private readonly TripContext _context;

        public TripRepository(TripContext context)
        {
            _context = context;
        }

        public async Task<Trip> GetTripByIdAsync(int id)
        {
            return await _context.Trips
                .Include(x => x.Description.Select(x => x.ToString()))
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IReadOnlyList<Trip>> GetTripsAsync()
        {
            return await _context.Trips.ToListAsync();
        }
    }
}
