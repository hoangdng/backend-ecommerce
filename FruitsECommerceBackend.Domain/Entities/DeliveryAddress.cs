namespace FruitsECommerceBackend.Domain.Entities
{
    public class DeliveryAddress
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Note { get; set; }

        #region navigation properties

        public int CustomerId { get; set; }

        #endregion
    }
}
