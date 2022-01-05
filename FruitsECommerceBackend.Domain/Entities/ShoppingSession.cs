namespace FruitsECommerceBackend.Domain.Entities
{
    public class ShoppingSession
    {
        public ShoppingSession()
        {
            CartItems = new HashSet<CartItem>();
        }

        public int Id { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }

        #region navigation properties

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<CartItem> CartItems { get; set; }

        #endregion 
    }
}
