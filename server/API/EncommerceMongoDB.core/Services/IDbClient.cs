using EncommerceMongoDB.core.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core
{
    public interface IDbClient
    {
        IMongoCollection<Trademark> GetTrademarksCollection();

        IMongoCollection<Product> GetProductsCollection();

        IMongoCollection<Address> GetAddressCollection();

        IMongoCollection<Order> GetOrderCollection();

    }
}
