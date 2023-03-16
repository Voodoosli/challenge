using CatalogService.Data;
using CatalogService.Entities;
using CatalogService.Repositories.Abstract;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogService.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly CatalogContext _context;
        public ProductRepository(CatalogContext context)
        {
            _context = context;
        }
        public async Task CreateProduct(Product data)
        {
            await _context.Products.InsertOneAsync(data);
        }

        public async Task<bool> DeleteProduct(string id)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(x => x.Id, id);
            DeleteResult deleteResult = await _context.Products.DeleteOneAsync(filter); 
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<Product> GetProduct(string id)
        {
            return await _context.Products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByName(string name)
        {
            FilterDefinition<Product> filter = Builders<Product>.Filter.Eq(p => p.ProductName, name); 
            return await _context.Products.Find(filter).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _context.Products.Find(p => true).ToListAsync();
        }

        public async Task<bool> UpdateProduct(Product product)
        { 
            var updateResult = await _context.Products.ReplaceOneAsync(filter: x => x.Id == product.Id, replacement: product); 
            return updateResult.IsAcknowledged && updateResult.ModifiedCount > 0;
        }
    }
}
