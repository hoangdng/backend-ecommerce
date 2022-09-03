using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Application.Viewmodels
{
    public class Order
    {
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public OrderState State { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
