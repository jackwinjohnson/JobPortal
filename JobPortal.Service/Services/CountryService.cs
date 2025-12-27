using AutoMapper;
using JobPortal.DataAccess.Models;
using JobPortal.DataAccess.PortalRepository;
using JobPortal.Dtos.Dtos;
using JobPortal.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Service.Services
{
    public class CountryService : ICountryService
    {
        private readonly IRepository<Country> _countryRepository;
        private readonly IMapper _mapper;

        public CountryService(IRepository<Country> countryRepository, IMapper mapper)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
        }

        public async Task<CountryDto> AddAsync(CountryDto countryDto)
        {
         var country = _mapper.Map<Country>(countryDto);
            await _countryRepository.AddAsync(country);
            return countryDto;
        }

        public async Task<IEnumerable<CountryDto>> GetAllAsync()
        {
            var countries = await _countryRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<CountryDto>>(countries);
        }
    }
}
