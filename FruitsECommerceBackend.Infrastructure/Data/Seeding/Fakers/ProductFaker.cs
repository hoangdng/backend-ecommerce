using Bogus;
using FruitsECommerceBackend.Domain.Entities;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of Product entity.
    /// </summary>
    public class ProductFaker : Faker<Product>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ProductFaker()
        {
            RuleFor(p => p.Name, f => f.Commerce.ProductName());
            RuleFor(p => p.Description, f => f.Commerce.ProductDescription());
            RuleFor(p => p.Price, f => f.Random.Decimal(10000, 9999999));
            RuleFor(p => p.Quantity, f => f.Random.Number(1000));
            RuleFor(p => p.Categories, f => new CategoryFaker().GenerateBetween(1, 3));
        }
    }
}
