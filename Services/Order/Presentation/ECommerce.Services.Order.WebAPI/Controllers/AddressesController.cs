using ECommerce.Services.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Services.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Services.Order.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddressesController : ControllerBase
	{
		private readonly GetAddressQueryHandler _getAddressQueryHandler;
		private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;
		private readonly RemoveAddressCommandHandler _removeAddressCommandHandler;
		private readonly CreateAddressCommandHandler _createAddressCommandHandler;
		private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;

		public AddressesController(GetAddressQueryHandler getAddressQueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, RemoveAddressCommandHandler removeAddressCommandHandler, CreateAddressCommandHandler createAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler)
		{
			_getAddressQueryHandler = getAddressQueryHandler;
			_getAddressByIdQueryHandler = getAddressByIdQueryHandler;
			_removeAddressCommandHandler = removeAddressCommandHandler;
			_createAddressCommandHandler = createAddressCommandHandler;
			_updateAddressCommandHandler = updateAddressCommandHandler;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllAddresses()
		{
			var values = await _getAddressQueryHandler.Handle();
			return Ok(values);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetAddressById(int id)
		{
			var value = await _getAddressByIdQueryHandler.Handle(id);
			return Ok(value);
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAddress(int id)
		{
			await _removeAddressCommandHandler.Handle(id);
			return Ok("Adres Bilgisi Başarılı Bir Şekilde Silindi");
		}

		[HttpPost]
		public async Task<IActionResult> CreateAddress(CreateAddressCommand command)
		{
			await _createAddressCommandHandler.Handle(command);
			return Ok("Adres Bilgisi Başarılı Bir Şekilde Eklendi");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateAddress(UpdateAddressCommand command)
		{
			await _updateAddressCommandHandler.Handle(command);
			return Ok("Adres Bilgisi Başarılı Bir Şekilde Güncellendi");
		}
	}
}