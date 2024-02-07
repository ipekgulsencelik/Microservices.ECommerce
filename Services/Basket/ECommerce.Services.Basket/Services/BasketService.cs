using ECommerce.Services.Basket.DTOs;

namespace ECommerce.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public Task DeleteBasket(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task<BasketTotalDTO> GetBasketTotalAsync(string UserID)
        {
            throw new NotImplementedException();
        }

        public Task SaveBasket(BasketTotalDTO basketTotalDTO)
        {
            throw new NotImplementedException();
        }
    }
}