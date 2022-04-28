using EncommerceMongoDB.core.Models;
using MongoDB.Driver;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Services
{
    public interface IOrderService
    {
        Task AddOrderAsync(Order request);
        Task<Order> GetOrderAsync(string id);
        Task UpdateOrderAsync(Order order);
        Task DeleteProductAsync(Order order);
    }

    public class OrderService : IOrderService
    {
        private readonly IMongoCollection<Order> _order;
        public OrderService(IDbClient dbClient)
        {
            _order = dbClient.GetOrderCollection();
        }

        // Add a new order
        public async Task AddOrderAsync(Order request) => await _order.InsertOneAsync(request);

        //Get a order
        public async Task<Order> GetOrderAsync(string id)
        {
            var query = Builders<Order>.Filter.Eq("Id", id);
            return await _order.Find(query).SingleOrDefaultAsync();
        }

        //Update a order by id
        public async Task UpdateOrderAsync(Order order) => await _order.ReplaceOneAsync(o => o.Id == order.Id, order);

        //Delete a order by id
        public async Task DeleteProductAsync(Order order) => await _order.DeleteOneAsync(o => o.Id == order.Id);
    }

}
