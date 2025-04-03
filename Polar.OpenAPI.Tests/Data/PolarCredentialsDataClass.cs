using Polar.OpenAPI.Models;
using TUnit.Core.Interfaces;

namespace Polar.OpenAPI.Tests.Data
{
    public class PolarCredentialsDataClass : IAsyncInitializer, IAsyncDisposable
    {
        public string OrganizationId { get; private set; } = Guid.NewGuid().ToString();
        public string ProductId { get; private set; } = Guid.NewGuid().ToString();
        public string PriceId { get; private set; } = Guid.NewGuid().ToString();

        public ProductPrice Price { get; private set; }
        public Product Product { get; private set; }

        public PolarCredentialsDataClass()
        {
            Price = new ProductPrice
            {
                Id = PriceId,
                CreatedAt = DateTimeOffset.Now,
                ModifiedAt = null,
                IsArchived = false,
                ProductId = ProductId,
                PriceCurrency = "usd",
                PriceAmount = 1000,
                Type = ProductPriceType.One_time,
                AmountType = "fixed"
            };

            Product = new Product
            {
                Id = ProductId,
                CreatedAt = DateTimeOffset.Now,
                ModifiedAt = null,
                Name = "Product",
                Description = null,
                IsRecurring = false,
                IsArchived = false,
                OrganizationId = OrganizationId,
                Prices =
                [
                    new Product.Product_prices
                    {
                        ProductPrice = Price
                    }
                ],
                Benefits = [],
                Medias = [],
            };
        }

        public async Task InitializeAsync()
        {
        }

        public async ValueTask DisposeAsync()
        {
            await Console.Out.WriteLineAsync("And when the class is finished with, we can clean up any resources.");
        }
    }
}