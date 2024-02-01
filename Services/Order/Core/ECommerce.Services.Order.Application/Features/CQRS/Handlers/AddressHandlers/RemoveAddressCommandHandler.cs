using AutoMapper;
using ECommerce.Services.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;

namespace ECommerce.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
	public class RemoveAddressCommandHandler
	{
		private readonly IRepository<Address> _addressRepository;
		private readonly IMapper _mapper;

		public RemoveAddressCommandHandler(IRepository<Address> addressRepository, IMapper mapper)
		{
			_addressRepository = addressRepository;
			_mapper = mapper;
		}

		public async Task Handle(int id)
		{
			var query = new RemoveAddressCommand(id);
			await _addressRepository.DeleteAsync(query.Id);
		}
	}
}