using ECommerce.Services.Basket.DTOs;

namespace ECommerce.Services.Basket.Services
{
    public interface IBasketService
    {
        Task<BasketTotalDTO> GetBasketTotalAsync(string UserID);
        Task SaveBasket(BasketTotalDTO basketTotalDTO);
        Task DeleteBasket(string UserID);
    }
}