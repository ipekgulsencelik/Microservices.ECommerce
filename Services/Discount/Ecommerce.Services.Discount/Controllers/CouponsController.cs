using Ecommerce.Services.Discount.DTOs;
using Ecommerce.Services.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Services.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponsController : ControllerBase
    {
        private readonly ICouponService _couponService;

        public CouponsController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        [HttpGet]
        public async Task<IActionResult> CouponList()
        {
            var values = await _couponService.GetAllCouponsAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CreateCouponDTO createCouponDTO)
        {
            await _couponService.CreateCouponAsync(createCouponDTO);
            return Ok("Kupon Başarıyla Oluşturuldu.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCoupon(int id)
        {
            await _couponService.DeleteCouponAsync(id);
            return Ok("Kupon Silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCoupon(int id)
        {
            var values = await _couponService.GetCouponByIdAsync(id);
            return Ok(values);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCoupon(UpdateCouponDTO updateCouponDTO)
        {
            await _couponService.UpdateCouponAsync(updateCouponDTO);
            return Ok("Güncelleme Yapıldı");
        }
    }
}