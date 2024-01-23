using ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderingQueries;
using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderingResults;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class GetOrderingQueryHandler : IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
	{
		private readonly IRepository<Ordering> _repository;

		public GetOrderingQueryHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}

		public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();

			return values.Select(x => new GetOrderingQueryResult
			{
				OrderDate = x.OrderDate,
				OrderingID = x.OrderingID,
				TotalPrice = x.TotalPrice,
				UserID = x.UserID
			}).ToList();
		}
	}
}