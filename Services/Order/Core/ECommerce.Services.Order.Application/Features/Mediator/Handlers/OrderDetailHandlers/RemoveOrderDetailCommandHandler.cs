using AutoMapper;
using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands;
using ECommerce.Services.Order.Application.Interfaces;
using ECommerce.Services.Order.Domain.Entities;
using MediatR;

namespace ECommerce.Services.Order.Application.Features.Mediator.Handlers.OrderDetailHandlers
{
	internal class RemoveOrderDetailCommandHandler : IRequestHandler<RemoveOrderDetailCommand>
	{
		private readonly IRepository<OrderDetail> _repository;
		private readonly IMapper _mapper;

		public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}

		public async Task Handle(RemoveOrderDetailCommand request, CancellationToken cancellationToken)
		{
			await _repository.DeleteAsync(request.Id);
		}
	}
}