using AutoMapper;
using JobPortal.DataAccess.Models;
using JobPortal.Dtos.Dtos;

namespace JobPortal.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Address, AddressDto>().ReverseMap();
            CreateMap<Country, CountryDto>().ReverseMap();

        }
    }
}
