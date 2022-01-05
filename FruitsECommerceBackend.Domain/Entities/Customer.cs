using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Domain.Entities
{
    public class Customer
    {
        public Customer()
        {
            DeliveryAddresses = new HashSet<DeliveryAddress>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public MemberLevel Level { get; set; }

        #region navigation properties
        public int ShoppingSessionId { get; set; }
        public virtual ShoppingSession ShoppingSession { get; set; }
        public virtual ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        #endregion
    }
}