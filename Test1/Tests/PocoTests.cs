using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class PocoTests: AssertionHelper
    {
        public PocoTests()
        {
            JsonWriterSettings.Defaults.Indent = true;
        }

        [Test]
        public void ConvertToJson()
        {
            var plan = Stubs.HardCodedModel();

            System.Console.WriteLine(plan.ToJson());
        }

        [Test]
        public void Check_Id_Type()
        {
            var plan = Stubs.HardCodedModel();

            plan.Id = ObjectId.GenerateNewId().ToString();

            var doc = plan.ToBsonDocument();
            Expect(doc["_id"].BsonType, Is.EqualTo(BsonType.ObjectId));
        }
    }
}
