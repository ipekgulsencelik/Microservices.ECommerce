using AutoMapper;
using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommand>
	{
		private readonly IRepository<Ordering> _orderingRepository;
		private readonly IMapper _mapper;

		public RemoveOrderingCommandHandler(IRepository<Ordering> orderingRepository, IMapper mapper)
		{
			_orderingRepository = orderingRepository;
			_mapper = mapper;
		}

		public async Task Handle(RemoveOrderingCommand request, CancellationToken cancellationToken)
		{
			await _orderingRepository.DeleteAsync(request.Id);
		}
	}
}