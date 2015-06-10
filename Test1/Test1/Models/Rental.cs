using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace Test1.Models
{
    public class Rental
    {
        public Rental()
        {
            Address = new List<string>();
        }

        public Rental(PostRental postRental)
        {
            Description = postRental.Description;
            NoOfRooms = postRental.NoOfRooms;
            Price = postRental.Price;
            Address = (postRental.Address ?? string.Empty).Split('\n').ToList();
        }
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Description { get; set; }
        public int NoOfRooms { get; set; }
        [BsonRepresentation(BsonType.Double)]
        public decimal Price { get; set; }
        public List<string> Address { get; set; }
    }
}