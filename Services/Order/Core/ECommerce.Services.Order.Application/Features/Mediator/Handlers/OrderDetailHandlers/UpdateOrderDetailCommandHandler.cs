using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderDetailHandlers
{
	public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommand>
	{
		private readonly IRepository<OrderDetail> _repository;

		public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateOrderDetailCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.OrderDetailID);

			values.ProductID = request.ProductID;
			values.ProductName = request.ProductName;
			values.ProductPrice = request.ProductPrice;
			values.ProductAmount = request.ProductAmount;
			values.TotalPrice = request.TotalPrice;
			values.OrderingID = request.OrderingID;

			await _repository.UpdateAsync(values);
		}
	}
}