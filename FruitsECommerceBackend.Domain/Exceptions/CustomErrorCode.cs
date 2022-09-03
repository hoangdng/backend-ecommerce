namespace FruitsECommerceBackend.Domain.Exceptions
{
    /// <summary>
    /// Custom error code
    /// </summary>
    public enum CustomErrorCode
    {
        /// <summary>
        /// Offset parameter in query is negative
        /// </summary>
        OFFSET_NEGATIVE,

        /// <summary>
        /// Limit parameter in query is non-positive
        /// </summary>
        LIMIT_NONPOSITIVE,
    }
}
