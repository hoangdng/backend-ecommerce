namespace FruitsECommerceBackend.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        #region navigation properties


        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }

        #endregion
    }
}
