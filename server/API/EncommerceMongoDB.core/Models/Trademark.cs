
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace EncommerceMongoDB.core
{
    public class Trademark 
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        public string trade_name { get; set; }

        public DateTime create_date { get; set; }

    }
}
