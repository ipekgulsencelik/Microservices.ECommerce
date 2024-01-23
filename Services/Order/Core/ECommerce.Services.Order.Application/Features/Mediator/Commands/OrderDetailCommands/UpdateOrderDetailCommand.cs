using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands
{
	public class UpdateOrderDetailCommand : IRequest
	{
		public int OrderDetailID { get; set; }
		public string? ProductID { get; set; }
		public string? ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductAmount { get; set; }
		public decimal TotalPrice { get; set; }
		public int OrderingID { get; set; }
	}
}