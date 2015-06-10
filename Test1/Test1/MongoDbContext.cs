using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1.Properties;

namespace Test1
{
    public class MongoDbContext
    {
        public MongoDatabase Database { get; private set; }
        public MongoDbContext()
        {
            var client = new MongoClient(Settings.Default.connectionString);
            var server = client.GetServer();
            //Database = client.GetDatabase(Settings.Default.databaseName);
            Database = server.GetDatabase(Settings.Default.databaseName);
        }
    }
}