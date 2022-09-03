using Bogus;
using FruitsECommerceBackend.Domain.Entities;

namespace FruitsECommerceBackend.Infrastructure.Data.Seeding.Fakers
{
    /// <summary>
    /// Faker of Category entity.
    /// </summary>
    public class CategoryFaker : Faker<Category>
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public CategoryFaker()
        {
            RuleFor(c => c.Name, f => f.Commerce.Categories(1).ElementAt(0));
            RuleFor(c => c.Description, f => f.Lorem.Sentences());
        }
    }
}
