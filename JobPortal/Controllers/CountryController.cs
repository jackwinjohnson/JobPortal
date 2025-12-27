using JobPortal.Dtos.Dtos;
using JobPortal.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<CountryDto>>> GetAllAsync()
        {
            var countries = await _countryService.GetAllAsync();
            return Ok(countries);
        }

        [HttpPost("Add")]
        public async Task<ActionResult<CountryDto>> AddAsync(CountryDto countryDto)
        {
            var country = await _countryService.AddAsync(countryDto);
            return country;
        }
    }


}
