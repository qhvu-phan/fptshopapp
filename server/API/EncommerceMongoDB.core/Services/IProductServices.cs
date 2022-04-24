using EncommerceMongoDB.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Services
{
    public interface IProductServices
    {
        Task<List<Product>> GetProductsAsync();

        Task AddProductAsync(Product product);

        Task<Product> GetProductAsync(string id);

        Task UpdateProductAsync(Product product);

        Task DeleteProductAsync(Product product);

        Task<List<Product>> SearchProducts(string proName);

        Task<List<Product>> GetProductsById_Trademark(string id);
    }
}
