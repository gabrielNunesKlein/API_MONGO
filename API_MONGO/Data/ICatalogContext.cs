using API_MONGO.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_MONGO.Data
{
    public interface ICatalogContext
    {
        public IMongoCollection<Product> Products { get; }
    }
}
