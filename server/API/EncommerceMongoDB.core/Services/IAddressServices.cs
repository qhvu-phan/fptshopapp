using EncommerceMongoDB.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Services
{
    public interface IAddressServices
    {
        Task<Address> GetAddressByIdAsync(string Id);

        Task AddNewAddressAsync(Address ad);

        Task UpdateAddress(Address ad);

        Task DeleteAddress(Address ad);
    }
}
