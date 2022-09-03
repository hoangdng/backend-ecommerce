namespace FruitsECommerceBackend.Application.Viewmodels
{
    /// <summary>
    /// Product view model
    /// </summary>
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public virtual IEnumerable<Category> Categories { get; set; }
    }
}
