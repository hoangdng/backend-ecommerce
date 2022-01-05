namespace FruitsECommerceBackend.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
            CartItems = new HashSet<CartItem>();
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        #region navigation properties

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

        #endregion 
    }
}
