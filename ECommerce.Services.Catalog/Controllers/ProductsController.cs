using ECommerce.Services.Catalog.DTOs.ProductDTOs;
using ECommerce.Services.Catalog.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var values = await _productService.GetAllProductsAsync();
            return Ok(values);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Ürün Başarılı Bir Şekilde Silindi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductByID(string id)
        {
            var value = await _productService.GetProductByIdAsync(id);
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDTO createProductDTO)
        {
            await _productService.CreateProductAsync(createProductDTO);
            return Ok("Ürün Başarılı Bir Şekilde Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            await _productService.UpdateProductAsync(updateProductDTO);
            return Ok("Ürün Başarılı Bir Şekilde Güncellendi.");
        }
    }
}