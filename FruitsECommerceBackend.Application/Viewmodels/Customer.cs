using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Application.Viewmodels
{
    public class Customer
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public MemberLevel Level { get; set; }
        public IEnumerable<DeliveryAddress> DeliveryAddresses { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}