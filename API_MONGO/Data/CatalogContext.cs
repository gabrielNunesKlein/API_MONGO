using API_MONGO.Entities;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_MONGO.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>
                ("MongoConnection:ConnectionString"));

            var database = client.GetDatabase(configuration.GetValue<string>
                ("MongoConnection:Database"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>
                ("MongoConnection:CollectionName"));

            CatalogContextSeed.seedData(Products);
        }

        public IMongoCollection<Product> Products { get; }
    }
}
