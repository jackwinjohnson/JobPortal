using JobPortal.Dtos.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Service.Interface
{
    public interface ICountryService
    {

        Task<IEnumerable<CountryDto>> GetAllAsync();

        Task<CountryDto>AddAsync(CountryDto countryDto);

    }
}
