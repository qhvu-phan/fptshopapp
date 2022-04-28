using EncommerceMongoDB.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Dtos
{
    public class CreateOrderDto
    {
        public string order_pro_id { get; set; }
        public int order_price { get; set; }
        /// <summary>
        /// Cancel = 0,
        /// Create = 1,
        /// Confirm = 2, 
        /// Delivery = 3,
        /// Done = 4
        /// </summary>
        public OrderStatus order_status { get; set; }
    }

    public class UpdateOrderDto
    {
        public string order_pro_id { get; set; }
        public int order_price { get; set; }
        /// <summary>
        /// Cancel = 0,
        /// Create = 1,
        /// Confirm = 2, 
        /// Delivery = 3,
        /// Done = 4
        /// </summary>
        public OrderStatus order_status { get; set; }
    }
}
