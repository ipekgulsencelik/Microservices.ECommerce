using Ecommerce.Services.Discount.DTOs;

namespace Ecommerce.Services.Discount.Services
{
    public class CouponService : ICouponService
    {
        public Task CreateCouponAsync(CreateCouponDTO createCouponDTO)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCouponAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCouponDTO>> GetAllCouponsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultCouponDTO> GetCouponByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCouponAsync(UpdateCouponDTO updateCouponDTO)
        {
            throw new NotImplementedException();
        }
    }
}