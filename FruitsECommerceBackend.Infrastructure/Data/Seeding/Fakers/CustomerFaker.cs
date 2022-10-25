using Bogus;
using FruitsECommerceBackend.Domain.Entities;
using FruitsECommerceBackend.Domain.Shared;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of Customer entity.
    /// </summary>
    public class CustomerFaker : Faker<Customer>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomerFaker(string locale)
        {
            Locale = locale;
            RuleFor(c => c.Username, f => f.Person.UserName);
            RuleFor(c => c.Name, f => f.Person.FullName);
            RuleFor(c => c.Email, f => f.Person.Email);
            RuleFor(c => c.Level, f => f.PickRandom<MemberLevel>());
            RuleFor(c => c.DeliveryAddresses, f => new DeliveryAddressFaker().GenerateBetween(1, 3));
        }
    }
}
