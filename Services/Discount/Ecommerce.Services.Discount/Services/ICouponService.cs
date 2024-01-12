using Ecommerce.Services.Discount.DTOs;

namespace Ecommerce.Services.Discount.Services
{
    public interface ICouponService
    {
        Task<List<ResultCouponDTO>> GetAllCouponsAsync();
        Task CreateCouponAsync(CreateCouponDTO createCouponDTO);
        Task DeleteCouponAsync(int id);
        Task UpdateCouponAsync(UpdateCouponDTO updateCouponDTO);
        Task<ResultCouponDTO> GetCouponByIdAsync(int id);
    }
}