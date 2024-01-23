using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommand>
	{
		private readonly IRepository<Ordering> _repository;

		public CreateOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateOrderingCommand request, CancellationToken cancellationToken)
		{
			var order = new Ordering
			{
				UserID = request.UserID,
				TotalPrice = request.TotalPrice,
				OrderDate = request.OrderDate
			};

			await _repository.CreateAsync(order);
		}
	}
}