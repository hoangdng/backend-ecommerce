using FruitsECommerceBackend.Domain.Entities;
using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Domain.Entites
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

        public ICollection<DeliveryAddress> DeliveryAddresses { get; set; }
        public ICollection<Order> Orders { get; set; }

        #endregion
    }
}