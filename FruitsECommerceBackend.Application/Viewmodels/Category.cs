namespace FruitsECommerceBackend.Application.Viewmodels
{
    /// <summary>
    /// Category view model
    /// </summary>
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
