using Microsoft.AspNetCore.Mvc;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;

namespace Trips.Booking.API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _repo;

        public CustomersController(ICustomerRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetCustomers()
        {
            var trips = await _repo.GetCustomersAsync();
            return Ok(trips);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            return await _repo.GetCustomerByIdAsync(id);
        }
    }
}
