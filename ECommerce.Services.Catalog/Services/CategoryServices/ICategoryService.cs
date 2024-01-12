using ECommerce.Services.Catalog.DTOs.CategoryDTOs;

namespace ECommerce.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryService
	{
        Task<List<ResultCategoryDTO>> GetAllCategoriesAsync();
        Task<ResultCategoryDTO> GetCategoryByIdAsync(string id);
        Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO);
        Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO);
        Task DeleteCategoryAsync(string id);
    }
}