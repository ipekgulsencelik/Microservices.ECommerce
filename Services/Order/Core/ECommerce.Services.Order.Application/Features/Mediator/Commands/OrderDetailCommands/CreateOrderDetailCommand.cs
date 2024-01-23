using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands
{
	public class CreateOrderDetailCommand : IRequest
	{
		public string? ProductID { get; set; }
		public string? ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductAmount { get; set; }
		public decimal TotalPrice { get; set; }
		public int OrderingID { get; set; }
	}
}