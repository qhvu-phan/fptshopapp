using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Models
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string order_pro_id { get; set; }
        public int order_price { get; set; }
        public OrderStatus order_status { get; set; }
    }

    public enum OrderStatus
    {
        Cancel = 0,
        Create = 1,
        Confirm = 2,
        Delivery = 3,
        Done = 4
    }
}
