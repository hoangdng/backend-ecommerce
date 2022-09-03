using Bogus;
using FruitsECommerceBackend.Domain.Entities;
using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of Order entity.
    /// </summary>
    public class OrderFaker : Faker<Order>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public OrderFaker()
        {
            RuleFor(o => o.CreatedAt, f => f.Date.Past());
            RuleFor(o => o.State, f => f.PickRandom<OrderState>());
            RuleFor(o => o.OrderItems, f => new OrderItemFaker().GenerateBetween(1, 3));
            FinishWith((f, current) =>
            {
                current.TotalQuantity = current.OrderItems.Aggregate(0, (sum, item) => sum + item.Quantity);
                current.TotalPrice = current.OrderItems.Aggregate(0m, (sum, item) => sum + (item.Quantity * item.Product.Price));
            });
        }
    }
}
