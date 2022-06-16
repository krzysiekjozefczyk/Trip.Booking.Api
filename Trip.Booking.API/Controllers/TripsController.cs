using Microsoft.AspNetCore.Mvc;
using Trips.Booking.Core.Dtos;
using Trips.Booking.Core.Entities;
using Trips.Booking.Core.Interfaces;

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

        [HttpPost("create")]
        public async Task<ActionResult<Trip>> CreateTrip(TripDto model)
        {
            await _repo.CreateTripAsync(model);

            return Ok(new { message = "Trip created" });
        }

        [HttpPut("update/{id}")]
        public async Task<ActionResult<Trip>> UpdateTrip(int id, TripDto model)
        {
            await _repo.UpdateTripAsync(id, model);

            return Ok(new { message = "Trip updated" });
        }

        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<Trip>> DeleteTrip(int id)
        {
            await _repo.DeleteTripAsync(id);

            return Ok(new { message = "Trip deleted" });
        }
    }
}
