namespace FruitsECommerceBackend.Domain.Entities
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        #region navigation properties

        public ICollection<Category> Categories { get; set; }

        #endregion 
    }
}
