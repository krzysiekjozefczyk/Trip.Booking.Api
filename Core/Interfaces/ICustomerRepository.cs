using Trips.Booking.Core.Dtos;
using Trips.Booking.Core.Entities;

namespace Trips.Booking.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerByIdAsync(int id);
        Task<IReadOnlyList<Customer>> GetCustomersAsync();
        Task RegisterAsync(CustomerDto model);
        Task UnregisterAsync(string email);
    }
}
