using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;
namespace Tests.poco
{
    class Location
    {
        public Location()
        {
            Details = new LocationDetails();
        }
        public string Address { get; set; }
        [BsonRepresentation(BsonType.Double)]
        public decimal Lat { get; set; }
        [BsonRepresentation(BsonType.Double)]
        public decimal Lng { get; set; }
        public LocationDetails Details { get; set; }
    }
}
