using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Tests.poco
{
    class PlanViewModel
    {
        public PlanViewModel()
        {
            From = new Location();
            Destinations = new List<Location>();
            //add one empty field
            Destinations.Add(new Location());
        }
        //it must be named "Id". Otherwise it won't be recognized as "_id" in mongodb
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Location From { get; set; }
        public List<Location> Destinations { get; set; }
        public bool CompletedModel { get; set; }
    }
}
