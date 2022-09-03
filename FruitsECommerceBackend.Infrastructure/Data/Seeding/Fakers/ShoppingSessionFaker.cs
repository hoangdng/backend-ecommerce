using Bogus;
using FruitsECommerceBackend.Domain.Entities;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of ShoppingSession entity.
    /// </summary>
    public class ShoppingSessionFaker : Faker<ShoppingSession>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public ShoppingSessionFaker()
        {
            RuleFor(ss => ss.CartItems, f => new CartItemFaker().GenerateBetween(1,10));
        }
    }
}
