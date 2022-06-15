using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;
using Trips.Booking.Infrastructure.Data;

namespace Trips.Booking.API.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    public class TripsController  : ControllerBase
    {
        private readonly ITripRepository _repo;

        public TripsController(ITripRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<ActionResult<List<Trip>>> GetTrips()
        {
            var trips = await _repo.GetTripsAsync();
            return Ok(trips);
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<Trip>> GetTrip(int id)
        {
            return await _repo.GetTripByIdAsync(id);
        }
    }
}
