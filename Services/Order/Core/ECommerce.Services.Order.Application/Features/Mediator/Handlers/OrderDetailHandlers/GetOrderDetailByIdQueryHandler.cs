using ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderDetailQueries;
using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderDetailResults;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderDetailHandlers
{
	public class GetOrderDetailByIdQueryHandler : IRequestHandler<GetOrderDetailByIdQuery, GetOrderDetailByIdQueryResult>
	{
		private readonly IRepository<OrderDetail> _repository;

		public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.Id);

			return new GetOrderDetailByIdQueryResult
			{
				OrderDetailID = values.OrderDetailID,
				ProductID = values.ProductID,
				ProductName = values.ProductName,
				ProductPrice = values.ProductPrice,
				ProductAmount = values.ProductAmount,
				TotalPrice = values.TotalPrice,
				OrderingID = values.OrderingID
			};
		}
	}
}