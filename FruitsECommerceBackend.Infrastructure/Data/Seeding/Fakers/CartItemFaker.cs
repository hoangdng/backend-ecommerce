using Bogus;
using FruitsECommerceBackend.Domain.Entities;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of CartItem entity.
    /// </summary>
    public class CartItemFaker : Faker<CartItem>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public CartItemFaker()
        {
            RuleFor(ci => ci.Quantity, f => f.PickRandom<int>());
            RuleFor(ci => ci.Product, f => new ProductFaker().Generate());
        }
    }
}
