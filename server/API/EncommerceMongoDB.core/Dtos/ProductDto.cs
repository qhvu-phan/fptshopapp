using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Dtos
{
    public class ProductDto
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string pro_name { get; set; }

        public double pro_price { get; set; }

        public int pro_quantity { get; set; }

        public string pro_description { get; set; }

        public bool pro_active { get; set; }

        public DateTime pro_createDate { get; set; }

        public DateTime pro_updateDate { get; set; }

        public string pro_sale { get; set; }

        public string pro_trademarkId { get; set; }

        public string pro_detailId { get; set; }
    }
}
