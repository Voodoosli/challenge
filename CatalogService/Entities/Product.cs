

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CatalogService.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("ProductName")]
        public string ProductName { get; set; } 
        public string Descriptions { get; set; } 
        public decimal Price { get; set; }
      
    }
}
