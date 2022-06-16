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

            CreateMap<Customer, CustomerDto>()
                .ForMember(d => d.TripId, o => o.MapFrom(s => s.Trip.Id))
                .ForMember(d => d.TripName, o => o.MapFrom(s => s.Trip.Name))
                .ForMember(d => d.Country, o => o.MapFrom(s => s.Trip.Country))
                .ForMember(d => d.TripDescription, o => o.MapFrom(s => s.Trip.Description))
                .ForMember(d => d.StartDate, o => o.MapFrom(s => s.Trip.StartDate));

            CreateMap<CustomerDto, Customer>()
                .ForPath(d => d.Trip.Id, o => o.MapFrom(s => s.TripId))
                .ForPath(d => d.Trip.Name, o => o.MapFrom(s => s.TripName))
                .ForPath(d => d.Trip.Country, o => o.MapFrom(s => s.Country))
                .ForPath(d => d.Trip.Description, o => o.MapFrom(s => s.TripDescription))
                .ForPath(d => d.Trip.StartDate, o => o.MapFrom(s => s.StartDate));
        }
    }
}
