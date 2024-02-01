using AutoMapper;
using ECommerce.Services.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;

namespace ECommerce.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
	public class CreateAddressCommandHandler
	{
		private readonly IRepository<Address> _repository;
		private readonly IMapper _mapper;

		public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task Handle(CreateAddressCommand command)
		{
			var address = _mapper.Map<Address>(command);
			await _repository.CreateAsync(address);
		}
	}
}