using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existingProduct = productCollection.Find(p => true).Any();
            if(!existingProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        private static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "62f6a5ba3a61c6a40bf864cd",
                    Name = "Apple iPhone 13 128gb",
                    Summary = "The iPhone 13 and iPhone 13 mini are Apple's mid-tier flagship iPhones.",
                    Description = "Introduced on September 14, 2021, the iPhone 13 and iPhone 13 mini are Apple's newest flagship iPhones at the more affordable end, and are being sold alongside the more expensive iPhone 13 Pro and iPhone 13 Pro Max. The iPhone 13 and iPhone 13 mini are ideal for those who don't need pro-level camera features.",
                    ImageFile = "iphone-13.png",
                    Price = 1389.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "62f6a6f004ac59198d55a425",
                    Name = "Apple iPhone 13 256gb",
                    Summary = "The iPhone 13 and iPhone 13 mini are Apple's mid-tier flagship iPhones.",
                    Description = "Introduced on September 14, 2021, the iPhone 13 and iPhone 13 mini are Apple's newest flagship iPhones at the more affordable end, and are being sold alongside the more expensive iPhone 13 Pro and iPhone 13 Pro Max. The iPhone 13 and iPhone 13 mini are ideal for those who don't need pro-level camera features.",
                    ImageFile = "iphone-13.png",
                    Price = 1589.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "62f6a6f495035859dcab3c8b",
                    Name = "Samsung Galaxy S23",
                    Summary = "Samsung's latest and greatest flagship phone.",
                    Description = "Overlook the Samsung Galaxy S22 at your peril. It's true that the entry-level phone in Samsung's flagship lineup for this year lacks the premium features of the Galaxy S22 Ultra and the larger screen of the Galaxy S22 Plus, but there's a danger in focusing too much on what the S22 doesn't have.",
                    ImageFile = "samsung-galaxy-s23.png",
                    Price = 1056.00M,
                    Category = "Smartphone"
                },
            };
        }
    }
}
