using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Trips.Booking.Core.Dtos;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;

namespace Trips.Booking.Infrastructure.Data
{
    public class CustomerRepository : ICustomerRepository
    {
        private TripContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(TripContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _context.Customers
                .Include(x => x.Trip).Where(x => x.Trip != null)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IReadOnlyList<Customer>> GetCustomersAsync()
        {
            return await _context.Customers
                .Include(x => x.Trip)
                .ToListAsync();
        }

        public async Task RegisterAsync(CustomerDto model)
        {
            if (_context.Customers.Any(x => x.Email == model.Email))
                throw new ApplicationException($"Email {model.Email} is already taken.");

            var trip = await _context.Trips.FirstOrDefaultAsync(x => x.Name == model.TripName);
            if (trip != null)
            {
                model.TripId = trip.Id;
                model.TripDescription = trip.Description;
                model.StartDate = trip.StartDate.ToString();
                model.Country = trip.Country;

                var customer = _mapper.Map(model, new Customer { Trip = trip });
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UnregisterAsync(string email)
        {
            var customer = await _context.Customers.Include(x => x.Trip).FirstOrDefaultAsync(x => x.Email == email && x.Trip != null);
            if(customer == null)
                throw new ApplicationException($"This {email} has no trips assigned.");

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
