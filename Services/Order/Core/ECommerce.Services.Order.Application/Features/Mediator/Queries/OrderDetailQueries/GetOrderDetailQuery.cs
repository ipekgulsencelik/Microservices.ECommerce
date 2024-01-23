using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderDetailResults;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderDetailQueries
{
	public class GetOrderDetailQuery : IRequest<List<GetOrderDetailQueryResult>>
	{
	}
}