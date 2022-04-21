using EncommerceMongoDB.core.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;

namespace EncommerceMongoDB.core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Trademark> _trademark;

        private readonly IMongoCollection<Product> _product;

        public DbClient(IOptions<EcommercestoreDbConfig> ecommercestoreDbConfig)
        {
            var client = new MongoClient(ecommercestoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(ecommercestoreDbConfig.Value.Database_Name);
            _trademark = database.GetCollection<Trademark>(ecommercestoreDbConfig.Value.Trademark_Collection);
            _product = database.GetCollection<Product>(ecommercestoreDbConfig.Value.Product_Collection);

        }

   

        public IMongoCollection<Product> GetProductsCollection() => _product;


        public IMongoCollection<Trademark> GetTrademarksCollection() => _trademark;

    }
}
