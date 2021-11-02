using API_MONGO.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_MONGO.Data
{
    public class CatalogContextSeed
    {
        public static void seedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();

            if (!existProduct)
            {
                productCollection.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "001hnd34poaencietqhtenbt", Name = "Iphone", Description = "Produto novo",
                    Image = "img1.png", Price = 950.00M, Category = "Celular"
                },
                new Product()
                {
                    Id = "002hnd34loaencietqhtenbt", Name = "Playtation 4", Description = "Produto novo",
                    Image = "img2.png", Price = 1500.00M, Category = "Consoles"
                },
            };
        }
    }
}
