using ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderDetailQueries;
using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderDetailResults;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderDetailHandlers
{
	public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, List<GetOrderDetailQueryResult>>
	{
		private readonly IRepository<OrderDetail> _repository;

		public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetOrderDetailQueryResult>> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();

			return values.Select(x => new GetOrderDetailQueryResult
			{
				OrderDetailID = x.OrderDetailID,
				ProductID = x.ProductID,
				ProductName = x.ProductName,
				ProductPrice = x.ProductPrice,
				ProductAmount = x.ProductAmount,
				TotalPrice = x.TotalPrice,
				OrderingID = x.OrderingID
			}).ToList();
		}
	}
}