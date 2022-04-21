using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core
{
    
    public interface ITrademarkServices
    {
        Task<List<Trademark>> GetTrademarksAsync();

        Task<Trademark> GetTrademarkAsync(string id);

        Task AddTrademarkAsync(Trademark trademark);

        Task DeleteTrademarkAsync(string id);

        Task UpdateTrademarkAsync(Trademark trademark);
    }
}
