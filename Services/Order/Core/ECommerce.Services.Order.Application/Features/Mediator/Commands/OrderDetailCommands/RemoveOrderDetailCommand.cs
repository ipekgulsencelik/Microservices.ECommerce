using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands
{
	public class RemoveOrderDetailCommand : IRequest
	{
		public RemoveOrderDetailCommand(int id)
		{
			Id = id;
		}

		public int Id { get; set; }
	}
}