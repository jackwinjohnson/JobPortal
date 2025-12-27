using AutoMapper;
using JobPortal.DataAccess.Models;
using JobPortal.DataAccess.PortalRepository;
using JobPortal.Dtos.Dtos;
using JobPortal.Service.Interface;

namespace JobPortal.Service.Services
{
    public class AddressService : IAddressService
    {
        private readonly IRepository<Address> _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(IRepository<Address> addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }
        public async Task<AddressDto> AddAsync(AddressDto addressDto)
        {

            var address = _mapper.Map<Address>(addressDto);

            await _addressRepository.AddAsync(address);

            return addressDto;
        }

        public async Task<IEnumerable<AddressDto>> GetAllAsync()
        {
            var addresses = await _addressRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<AddressDto>>(addresses);
        }
    }
}
