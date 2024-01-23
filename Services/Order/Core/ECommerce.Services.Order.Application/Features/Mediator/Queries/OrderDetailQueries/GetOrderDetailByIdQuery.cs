using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderDetailResults;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderDetailQueries
{
	public class GetOrderDetailByIdQuery : IRequest<GetOrderDetailByIdQueryResult>
	{
		public GetOrderDetailByIdQuery(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}