using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderingResults;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderingQueries
{
	public class GetOrderingQuery : IRequest<List<GetOrderingQueryResult>>
	{
    }
}