using CatalogService.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace CatalogService.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> ProductCollection)
        {
            bool existProduct = ProductCollection.Find(p => true).Any();
            if (!existProduct)
            {
                ProductCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "6e21c0ef462e48a0ad3057264d5efd3f",
                    ProductName="Product 1",
                    Descriptions = "Product 1 Descriptions",
                    Price = 11.00M
                },
                new Product()
                {
                    Id = "b88d2300c00148ccba316f4decda5c6b",
                    ProductName="Product 2",
                    Descriptions = "Product 2 Descriptions",
                    Price = 12.00M,
                },
                new Product()
                {
                    Id = "4095184daed44953862a7351ef6dac9e",
                    ProductName="Product 3",
                    Descriptions = "Product 3 Descriptions",
                    Price = 13.00M,
                },
                new Product()
                {
                    Id = "82eb3de2a3694d6595fcaf2994ed3fd7", 
                    ProductName = "Product 4",
                    Descriptions = "Product 4 Descriptions", 
                    Price = 14.00M,
                    
                },
                new Product()
                {
                    Id = "987d5dd0281547c0b999635114568b1a",
                    ProductName = "Product 5",
                    Descriptions = "Product 5 Descriptions",
                    Price = 15.00M,
 
                },
            };
        }
    }
}
