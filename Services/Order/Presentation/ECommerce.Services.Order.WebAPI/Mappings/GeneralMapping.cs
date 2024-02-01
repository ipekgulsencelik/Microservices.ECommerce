using AutoMapper;
using ECommerce.Services.Order.Application.Features.CQRS.Commands.AddressCommands;
using ECommerce.Services.Order.Application.Features.CQRS.Results.AddressResults;
using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderDetailCommands;
using ECommerce.Services.Order.Application.Features.Mediator.Commands.OrderingCommands;
using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderDetailResults;
using ECommerce.Services.Order.Application.Features.Mediator.Results.OrderingResults;
using ECommerce.Services.Order.Domain.Entities;

namespace ECommerce.Services.Order.WebAPI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
			CreateMap<GetAddressQueryResult, Address>().ReverseMap();
			CreateMap<GetAddressByIdQueryResult, Address>().ReverseMap();
			CreateMap<CreateAddressCommand, Address>().ReverseMap();
			CreateMap<UpdateAddressCommand, Address>().ReverseMap();

			CreateMap<GetOrderingQueryResult, Ordering>().ReverseMap();
			CreateMap<GetOrderingByIdQueryResult, Ordering>().ReverseMap();
			CreateMap<CreateOrderingCommand, Ordering>().ReverseMap();
			CreateMap<UpdateOrderingCommand, Ordering>().ReverseMap();

			CreateMap<GetOrderDetailQueryResult, OrderDetail>().ReverseMap();
			CreateMap<GetOrderDetailByIdQueryResult, OrderDetail>().ReverseMap();
			CreateMap<CreateOrderDetailCommand, OrderDetail>().ReverseMap();
			CreateMap<UpdateOrderDetailCommand, OrderDetail>().ReverseMap();
		}
    }
}