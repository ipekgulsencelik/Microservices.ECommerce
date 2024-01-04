using AutoMapper;
using ECommerce.Services.Catalog.DTOs.CategoryDTOs;
using ECommerce.Services.Catalog.DTOs.ProductDTOs;
using ECommerce.Services.Catalog.Models;

namespace ECommerce.Services.Catalog.Mappings
{
	public class GeneralMapping : Profile
	{
		public GeneralMapping()
		{
			CreateMap<Category, ResultCategoryDTO>();
			CreateMap<ResultCategoryDTO, Category>();
			CreateMap<Category, CreateCategoryDTO>().ReverseMap();
			CreateMap<Category, UpdateCategoryDTO>().ReverseMap();

			CreateMap<Product, ResultProductDTO>().ReverseMap();
			CreateMap<Product, CreateProductDTO>().ReverseMap();
			CreateMap<Product, UpdateProductDTO>().ReverseMap();	
		}
	}
}