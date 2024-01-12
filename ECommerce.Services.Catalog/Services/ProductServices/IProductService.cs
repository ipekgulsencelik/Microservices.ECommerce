using ECommerce.Services.Catalog.DTOs.ProductDTOs;

namespace ECommerce.Services.Catalog.Services.ProductServices
{
    public interface IProductService
	{
        Task<List<ResultProductDTO>> GetAllProductsAsync();
        Task<ResultProductDTO> GetProductByIdAsync(string id);
        Task CreateProductAsync(CreateProductDTO createProductDTO);
        Task DeleteProductAsync(string id);
        Task UpdateProductAsync(UpdateProductDTO updateProductDTO);
    }
}