using AutoMapper;
using Trips.Booking.Core.Dtos;
using Trips.Booking.Core.Entities;

namespace Trips.Booking.API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Trip, TripDto>();
            CreateMap<TripDto, Trip>();
        }
    }
}
