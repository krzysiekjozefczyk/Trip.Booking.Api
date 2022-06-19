using Microsoft.AspNetCore.Mvc;
using Trips.Booking.Core.Dtos;
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
            var customers = await _repo.GetCustomersAsync();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            return await _repo.GetCustomerByIdAsync(id);
        }

        [HttpPost("register")]
        public async Task<ActionResult<Trip>> Register(CustomerDto model)
        {
            await _repo.RegisterAsync(model);

            return Ok(new { message = "Register successful" });
        }
        [HttpDelete("unregister/{email}")]
        public async Task<ActionResult<Trip>> Unregister(string email)
        {
            await _repo.UnregisterAsync(email);

            return Ok(new { message = "Unregister successful" });
        }
    }
}
