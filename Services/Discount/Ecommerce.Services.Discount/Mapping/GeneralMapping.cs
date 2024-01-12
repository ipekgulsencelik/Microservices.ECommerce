using AutoMapper;
using Ecommerce.Services.Discount.DTOs;
using Ecommerce.Services.Discount.Models;

namespace Ecommerce.Services.Discount.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Coupon, CreateCouponDTO>().ReverseMap();
            CreateMap<Coupon, UpdateCouponDTO>().ReverseMap();
            CreateMap<Coupon, ResultCouponDTO>().ReverseMap();
        }
    }
}