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

        private readonly IMongoCollection<Address> _address;

        private readonly IMongoCollection<Order> _order;

        public DbClient(IOptions<EcommercestoreDbConfig> ecommercestoreDbConfig)
        {
            var client = new MongoClient(ecommercestoreDbConfig.Value.Connection_String);
            var database = client.GetDatabase(ecommercestoreDbConfig.Value.Database_Name);
            _trademark = database.GetCollection<Trademark>(ecommercestoreDbConfig.Value.Trademark_Collection);
            _product = database.GetCollection<Product>(ecommercestoreDbConfig.Value.Product_Collection);
            _address = database.GetCollection<Address>(ecommercestoreDbConfig.Value.Address_Collection);
            _order = database.GetCollection<Order>(ecommercestoreDbConfig.Value.Order_Collection);
        }

        public IMongoCollection<Address> GetAddressCollection() => _address;

        public IMongoCollection<Product> GetProductsCollection() => _product;


        public IMongoCollection<Trademark> GetTrademarksCollection() => _trademark;

        public IMongoCollection<Order> GetOrderCollection() => _order;

    }
}
