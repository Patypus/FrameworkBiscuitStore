using MongoDB.Bson.Serialization.Attributes;

namespace Data.Entities
{
    public class Biscuit
    {
        [BsonId]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    }
}