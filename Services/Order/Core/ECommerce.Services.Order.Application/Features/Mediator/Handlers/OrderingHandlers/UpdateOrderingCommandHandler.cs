using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class UpdateOrderingCommandHandler : IRequestHandler<UpdateOrderingCommand>
	{
		private readonly IRepository<Ordering> _repository;

		public UpdateOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.OrderingID);

			values.OrderDate = request.OrderDate;
			values.UserID = request.UserID;
			values.TotalPrice = request.TotalPrice;

			await _repository.UpdateAsync(values);
		}
	}
}