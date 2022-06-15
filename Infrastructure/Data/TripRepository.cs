using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Trips.Booking.Core.Dtos;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;

namespace Trips.Booking.Infrastructure.Data
{
    public class TripRepository : ITripRepository
    {
        private TripContext _context;
        private readonly IMapper _mapper;

        public TripRepository(TripContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Trip> GetTripByIdAsync(int id)
        {
            return await _context.Trips.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IReadOnlyList<Trip>> GetTripsAsync()
        {
            return await _context.Trips.ToListAsync();
        }

        public async Task CreateTripAsync(TripDto model)
        {
            if (_context.Trips.Any(x => x.Name == model.Name))
                throw new ApplicationException($"Name {model.Name} is already taken ");

            var trip = _mapper.Map<TripDto, Trip>(model);

            _context.Trips.Add(trip);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTripAsync(int id, TripDto model)
        {
            var trip = await GetTripByIdAsync(id);

            if(model.Name != trip.Name && _context.Trips.Any(x => x.Name == model.Name))
                throw new ApplicationException($"Name {model.Name} is already taken ");

            _mapper.Map(model, trip);
            _context.Trips.Update(trip);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteTripAsync(int id)
        {
            var trip = await GetTripByIdAsync(id);
            _context.Trips.Remove(trip);
            await _context.SaveChangesAsync();
        }
    }
}
