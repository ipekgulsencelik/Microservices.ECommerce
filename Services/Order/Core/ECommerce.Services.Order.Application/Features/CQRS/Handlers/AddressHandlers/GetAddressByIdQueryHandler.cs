using AutoMapper;
using ECommerce.Services.Order.Application.Features.CQRS.Queries.AddressQueries;
using ECommerce.Services.Order.Application.Features.CQRS.Results.AddressResults;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;

namespace ECommerce.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
	public class GetAddressByIdQueryHandler
	{
		private readonly IRepository<Address> _repository;
		private readonly IMapper _mapper;

		public GetAddressByIdQueryHandler(IRepository<Address> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task<GetAddressByIdQueryResult> Handle(int id)
		{
			var query = new GetAddressByIdQuery(id);
			var value = await _repository.GetByIdAsync(query.Id);
			return _mapper.Map<GetAddressByIdQueryResult>(value);
		}
	}
}