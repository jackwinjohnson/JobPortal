using JobPortal.Dtos.Dtos;
using JobPortal.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;
        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }


        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<AddressDto>>> GetAllAsync()
        {
            var addresses = await _addressService.GetAllAsync();
            return Ok(addresses);
        }

        [HttpPost("Add")]
        public async Task<ActionResult<AddressDto>> AddAsync( AddressDto addressDto)
        {
            var address = await _addressService.AddAsync(addressDto);
            return address;
        }


    }
}
