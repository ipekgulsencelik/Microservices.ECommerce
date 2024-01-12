using AutoMapper;
using ECommerce.Services.Catalog.DTOs.ProductDTOs;
using ECommerce.Services.Catalog.Models;
using ECommerce.Services.Catalog.Settings;
using MongoDB.Driver;

namespace ECommerce.Services.Catalog.Services.ProductServices
{
	public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _productCollection;
        private readonly IMapper _mapper;

        public ProductService(IMapper mapper, IDatabaseSettings databaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient();
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _productCollection = database.GetCollection<Product>(databaseSettings.ProductCollectionName);
        }

        public async Task CreateProductAsync(CreateProductDTO createProductDTO)
        {
            var newProduct = _mapper.Map<Product>(createProductDTO);
            await _productCollection.InsertOneAsync(newProduct);
        }

        public async Task DeleteProductAsync(string id)
        {
            await _productCollection.DeleteOneAsync(x => x.ProductID == id);
        }

        public async Task<List<ResultProductDTO>> GetAllProductsAsync()
        {
            var products = await _productCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultProductDTO>>(products);
        }

        public async Task<ResultProductDTO> GetProductByIdAsync(string id)
        {
            var product = await _productCollection.Find(x => x.ProductID == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultProductDTO>(product);
        }

        public async Task UpdateProductAsync(UpdateProductDTO updateProductDTO)
        {
            var updateProduct = _mapper.Map<Product>(updateProductDTO);
            await _productCollection.FindOneAndReplaceAsync(x => x.ProductID == updateProductDTO.ProductID, updateProduct);
        }
    }
}