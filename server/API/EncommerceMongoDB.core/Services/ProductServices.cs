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

        private readonly IMongoCollection<Trademark> _trademark;

        public ProductServices(IDbClient dbClient)
        {
            _product = dbClient.GetProductsCollection();
            _trademark = dbClient.GetTrademarksCollection();
        }

        // Get all products
        public async Task<List<Product>> GetProductsAsync() => await _product.Find(product => true).ToListAsync();

        // add a new product
        public async Task AddProductAsync(Product product) => await _product.InsertOneAsync(product);

        // get a product by id
        public async Task<Product> GetProductAsync(string id)
        {
            var query = Builders<Product>.Filter.Eq("Id", id);
            return await _product.Find(query).SingleOrDefaultAsync();
        }

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

        // get products by id of trademark
        public async Task<List<Product>> GetProductsById_Trademark(string id)
        {
            var trademark = await _trademark.Find(tr => tr.Id == id).FirstOrDefaultAsync();
            
            var query = Builders<Product>.Filter.Where(pro => pro.pro_trademarkId == trademark.Id);
            return await _product.Find(query).ToListAsync();
        }
    }
}
