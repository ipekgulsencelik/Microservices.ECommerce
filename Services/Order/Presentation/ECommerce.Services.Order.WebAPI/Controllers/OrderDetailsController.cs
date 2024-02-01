using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands;
using ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderDetailQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Services.Order.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrderDetailsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public OrderDetailsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GetOrderDetails()
		{
			var values = await _mediator.Send(new GetOrderDetailQuery());
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommand command)
		{
			await _mediator.Send(command);
			return Ok("Sipariş Detayı Başarılı Bir Şekilde Oluşturuldu.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommand command)
		{
			await _mediator.Send(command);
			return Ok("Sipariş Detayı Başarılı Bir Şekilde Güncellendi.");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteOrderDetail(int id)
		{
			await _mediator.Send(new RemoveOrderDetailCommand(id));
			return Ok("Sipariş Detayı Başarılı Bir Şekilde Silindi.");
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetOrderDetailById(int id)
		{
			var value = await _mediator.Send(new GetOrderDetailByIdQuery(id));
			return Ok(value);
		}
	}
}