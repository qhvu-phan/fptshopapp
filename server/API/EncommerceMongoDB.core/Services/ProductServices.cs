using EncommerceMongoDB.core.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IMongoCollection<Product> _product;

        public ProductServices(IDbClient dbClient)
        {
            _product = dbClient.GetProductsCollection();
        }

        // Get all products
        public async Task<List<Product>> GetProductsAsync() => await _product.Find(product => true).ToListAsync();

        // add a new product
        public async Task AddProductAsync(Product product) => await _product.InsertOneAsync(product);

        // get a product by id
        public async Task<Product> GetProductAsync(string id) => await _product.Find(product => product.Id == id).SingleOrDefaultAsync();

        // update a product by id
        public async Task UpdateProductAsync(Product product) => await _product.ReplaceOneAsync(pro => pro.Id == product.Id, product);

        // delete a product by id
        public async Task DeleteProductAsync(Product product) => await _product.DeleteOneAsync(pro => pro.Id == product.Id);

        // search a product by string
        public async Task<List<Product>> SearchProducts(string proName)
        {
            try
            {
                var query = Builders<Product>.Filter.Where(pro => pro.pro_name.ToUpper().Contains(proName.ToUpper()));
                return await _product.Find(query).ToListAsync();
            }
            catch
            {
                return new List<Product>();
            }
        }

    }
}
