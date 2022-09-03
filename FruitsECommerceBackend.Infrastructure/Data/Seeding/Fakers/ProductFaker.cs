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
            RuleFor(p => p.Price, f => Convert.ToDecimal(f.Commerce.Price(10000, 10000000, 0, "VNĐ")));
            RuleFor(p => p.Quantity, f => f.PickRandom<int>());
            RuleFor(p => p.Categories, f => new CategoryFaker().GenerateBetween(1, 3));
        }
    }
}
