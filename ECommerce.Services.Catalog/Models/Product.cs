﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerce.Services.Catalog.Models
{
	public class Product
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string ProductID { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public int ProductStock { get; set; }
		public string ProductImage { get; set; }

		[BsonRepresentation(BsonType.ObjectId)]
		public string CategoryID { get; set; }

		[BsonIgnore]
		public Category Category { get; set; }
	}
}