using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderDetailHandlers
{
	internal class RemoveOrderDetailCommandHandler : IRequestHandler<RemoveOrderDetailCommand>
	{
		private readonly IRepository<OrderDetail> _repository;

		public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(RemoveOrderDetailCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);

			await _repository.DeleteAsync(value);
		}
	}
}