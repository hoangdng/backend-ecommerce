using Bogus;
using FruitsECommerceBackend.Domain.Entities;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of OrderItem entity.
    /// </summary>
    public class OrderItemFaker : Faker<OrderItem>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public OrderItemFaker()
        {
            RuleFor(oi => oi.Quantity, f => f.PickRandom<int>());
            RuleFor(oi => oi.Product, f => new ProductFaker().Generate());
        }
    }
}
