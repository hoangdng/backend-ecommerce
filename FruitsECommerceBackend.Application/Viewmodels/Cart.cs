namespace FruitsECommerceBackend.Application.Viewmodels
{
    /// <summary>
    /// Cart view model
    /// </summary>
    public class Cart
    {
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public virtual IEnumerable<CartItem> Items { get; set; }
    }
}
