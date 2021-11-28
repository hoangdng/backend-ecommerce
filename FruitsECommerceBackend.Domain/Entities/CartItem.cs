namespace FruitsECommerceBackend.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        #region navigation properties

        public int ProductId { get; set; }
        public int SessionId { get; set; }

        #endregion
    }
}
