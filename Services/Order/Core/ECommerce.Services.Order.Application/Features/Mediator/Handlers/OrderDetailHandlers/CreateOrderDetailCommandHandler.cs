using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderDetailHandlers
{
	public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommand>
	{
		private readonly IRepository<OrderDetail> _repository;

		public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new OrderDetail
			{
				ProductID = request.ProductID,
				ProductName = request.ProductName,
				ProductPrice = request.ProductPrice,
				ProductAmount = request.ProductAmount,
				TotalPrice = request.TotalPrice,
				OrderDetailID = request.OrderingID
			});
		}
	}
}