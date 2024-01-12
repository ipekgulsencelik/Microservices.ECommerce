using AutoMapper;
using ECommerce.Services.Catalog.DTOs.CategoryDTOs;
using ECommerce.Services.Catalog.Models;
using ECommerce.Services.Catalog.Settings;
using MongoDB.Driver;

namespace ECommerce.Services.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;
     
        public CategoryService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            var client = new MongoClient();
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDTO createCategoryDTO)
        {
            var newCategory = _mapper.Map<Category>(createCategoryDTO);
            await _categoryCollection.InsertOneAsync(newCategory);
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryCollection.DeleteOneAsync(x => x.CategoryID == id);
        }

        public async Task<List<ResultCategoryDTO>> GetAllCategoriesAsync()
        {
            var categories = await _categoryCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultCategoryDTO>>(categories);
        }

        public async Task<ResultCategoryDTO> GetCategoryByIdAsync(string id)
        {
            var category = await _categoryCollection.Find(x => x.CategoryID == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultCategoryDTO>(category);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDTO updateCategoryDTO)
        {
            var updateCategory = _mapper.Map<Category>(updateCategoryDTO);
            await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryID == updateCategoryDTO.CategoryID, updateCategory);
        }
    }
}