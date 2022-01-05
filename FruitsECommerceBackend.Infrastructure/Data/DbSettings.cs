namespace FruitsECommerceBackend.Infrastructure.Data
{
    /// <summary>
    /// Connection string class
    /// </summary>
    public class DbSettings
    {
        /// <summary>
        /// Connection string to tracking database
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Database name.
        /// </summary>
        public string DbName { get; set; }

        /// <summary>
        /// Flag that indicates if InMemory Database or SQL Server Database is used
        /// </summary>
        public bool UseInMemory { get; set; }
    }
}
