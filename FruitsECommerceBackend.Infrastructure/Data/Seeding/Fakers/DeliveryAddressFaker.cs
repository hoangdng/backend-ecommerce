using Bogus;
using FruitsECommerceBackend.Domain.Entities;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of DeliveryAddress entity.
    /// </summary>
    public class DeliveryAddressFaker : Faker<DeliveryAddress>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public DeliveryAddressFaker()
        {
            RuleFor(da => da.Phone, f => f.Phone.PhoneNumber("0###-###-###"));
            RuleFor(da => da.Address, f => f.Address.FullAddress());
            RuleFor(da => da.City, f => f.Address.City());
            RuleFor(da => da.District, f => f.Address.StreetName());
            RuleFor(da => da.Ward, f => f.Address.Direction());
            RuleFor(da => da.Note, f => f.Lorem.Sentences());
        }
    }
}
