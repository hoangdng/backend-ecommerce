namespace FruitsECommerceBackend.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();  
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        #region navigation properties

        public ICollection<Product> Products { get; set; }

        #endregion
    }
}
