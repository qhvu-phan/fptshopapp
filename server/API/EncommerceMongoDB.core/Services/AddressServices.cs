using EncommerceMongoDB.core.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Services
{
    public class AddressServices : IAddressServices
    {
        public readonly IMongoCollection<Address> _address;

        public AddressServices(IDbClient dbClient)
        {
            _address = dbClient.GetAddressCollection();
        }
        public async Task AddNewAddressAsync(Address ad) => await _address.InsertOneAsync(ad);


        public async Task DeleteAddressAsync(Address ad) => await _address.DeleteOneAsync(address => address.Id == ad.Id);


        public async Task<Address> GetAddressByIdAsync(string Id) => await _address.Find(ad => ad.Id == Id).FirstOrDefaultAsync();


        public async Task UpdateAddressAsync(Address ad) => await _address.ReplaceOneAsync(address => address.Id == ad.Id, ad);

    }
}
