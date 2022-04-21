using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core
{
    public class TrademarkServices : ITrademarkServices
    {
        private readonly IMongoCollection<Trademark> _trademark;

        public TrademarkServices(IDbClient dbClient)
        {
            _trademark = dbClient.GetTrademarksCollection();
        }

        // get all trademark
        public async Task<List<Trademark>> GetTrademarksAsync() => await _trademark.Find(trademark => true).ToListAsync();
      
        // add a new trademark
        public async Task AddTrademarkAsync(Trademark trademark)
        {
            await _trademark.InsertOneAsync(trademark);
        }

        // get a trademark by id
        public async Task<Trademark> GetTrademarkAsync(string id)
        {
           
            return await _trademark.Find(trademark => trademark.Id == id).SingleOrDefaultAsync();
        }    

        // delete a trademark by id
        public async Task DeleteTrademarkAsync(string id)
        {
            await _trademark.DeleteOneAsync(trademark => trademark.Id == id);
        }

        // update a trademark by id
        public async Task UpdateTrademarkAsync(Trademark trademark) => await _trademark.ReplaceOneAsync(tmp => tmp.Id == trademark.Id, trademark);

    }
}
