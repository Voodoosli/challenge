using CatalogService.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatalogService.Repositories.Abstract
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(string id);
        Task<IEnumerable<Product>> GetProductByName(string name);
        Task CreateProduct(Product data);
        Task<bool> UpdateProduct(Product data);
        Task<bool> DeleteProduct(string id);
    }
}
