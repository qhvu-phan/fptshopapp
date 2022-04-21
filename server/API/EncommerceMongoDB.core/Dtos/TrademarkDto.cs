using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Dtos
{
    public class TrademarkDto
    {

        public string Id { get; set; }

        public string trade_name { get; set; }

        public DateTime create_date { get; set; }
    }
}
