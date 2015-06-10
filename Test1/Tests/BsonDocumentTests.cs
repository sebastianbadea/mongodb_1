using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class BsonDocumentTests
    {
        public BsonDocumentTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }
        [Test]
        public void CreateDocument()
        {
            var doc = new BsonDocument 
            {
                {"name", "Andrey Barney"},
                {"age", 54},
                {"sex", false}
            };
            //doc.Add("name", new BsonString("myName"));

            Console.WriteLine(doc.ToJson());
        }

        [Test]
        public void ConvertBsonDocument()
        {
            var doc = new BsonDocument 
            {
                {"name", "Nastratin"}
            };

            var bson = doc.ToBson();

            var deserialized = BsonSerializer.Deserialize<BsonDocument>(bson);

            Console.WriteLine(BitConverter.ToString(bson));
            Console.WriteLine();
            Console.WriteLine(deserialized);
        }
    }
}
