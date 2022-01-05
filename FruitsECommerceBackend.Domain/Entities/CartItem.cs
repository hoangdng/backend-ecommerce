namespace FruitsECommerceBackend.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        #region navigation properties

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int ShoppingSessionId { get; set; }
        public virtual ShoppingSession ShoppingSession { get; set; }

        #endregion
    }
}
