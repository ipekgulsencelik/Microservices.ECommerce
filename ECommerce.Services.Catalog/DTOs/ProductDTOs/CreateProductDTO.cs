namespace ECommerce.Services.Catalog.DTOs.ProductDTOs
{
	public class CreateProductDTO
	{
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductStock { get; set; }
		public string ProductImage { get; set; }
		public string CategoryID { get; set; }
	}
}