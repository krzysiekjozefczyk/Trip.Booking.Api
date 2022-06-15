using Microsoft.EntityFrameworkCore;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;

namespace Trips.Booking.Infrastructure.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly TripContext _context;

        public CustomerRepository(TripContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers
                .Include(x => x.Trip)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IReadOnlyList<Customer>> GetCustomersAsync()
        {
            return await _context.Customers
                .Include(x => x.Trip)
                .ToListAsync();
        }
    }
}
