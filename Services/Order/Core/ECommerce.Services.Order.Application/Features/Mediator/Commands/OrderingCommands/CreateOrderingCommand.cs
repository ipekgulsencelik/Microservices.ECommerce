using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands
{
	public class CreateOrderingCommand : IRequest
	{
		public string? UserID { get; set; }
		public decimal TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
	}
}