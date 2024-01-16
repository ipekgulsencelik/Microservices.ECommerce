using AutoMapper;
using ECommerce.Services.Order.Application.Features.CQRS.Results.AddressResults;
using ECommerce.Services.Order.Domain.Entities;

namespace ECommerce.Services.Order.WebAPI.Mappings
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<GetAddressQueryResult, Address>().ReverseMap();
            CreateMap<GetAddressByIdQueryResult, Address>().ReverseMap();
        }
    }
}
