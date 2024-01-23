using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderingHandlers
{
	public class RemoveOrderingCommandHandler : IRequestHandler<RemoveOrderingCommand>
	{
		private readonly IRepository<Ordering> _repository;
	
		public RemoveOrderingCommandHandler(IRepository<Ordering> repository)
		{
			_repository = repository;
		}
		
		public async Task Handle(RemoveOrderingCommand request, CancellationToken cancellationToken)
		{
			var value = await _repository.GetByIdAsync(request.Id);

			await _repository.DeleteAsync(value);
		}
	}
}