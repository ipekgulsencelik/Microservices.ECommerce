using AutoMapper;
using ECommerce.Services.Order.Application.Features.CQRS.Results.AddressResults;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;

namespace ECommerce.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<List<GetAddressQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            var result = _mapper.Map<List<GetAddressQueryResult>>(values);
            return result;
        }
    }
}