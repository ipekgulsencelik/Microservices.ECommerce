using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands;
using ECommerce.Services.Order.Application.Features.Mediator.Queries.OrderingQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Services.Order.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IMediator _mediator;

		public OrdersController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> OrderingList()
		{
			var values = _mediator.Send(new GetOrderingQuery());
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateOrdering(CreateOrderingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Sipariş Başarılı Bir Şekilde Oluşturuldu");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateOrdering(UpdateOrderingCommand command)
		{
			await _mediator.Send(command);
			return Ok("Sipariş Başarılı Bir Şekilde Güncellendi");
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteOrdering(int id)
		{
			await _mediator.Send(new RemoveOrderingCommand(id));
			return Ok("Sipariş Başarılı Bir Şekilde Silindi");
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetOrderingById(int id)
		{
			var value = await _mediator.Send(new GetOrderingByIdQuery(id));
			return Ok(value);
		}
	}
}