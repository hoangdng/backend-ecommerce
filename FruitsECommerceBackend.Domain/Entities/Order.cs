using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Domain.Entities
{
    public class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public OrderState State { get; set; }

        #region navigation properties

        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        #endregion
    }
}
