namespace FruitsECommerceBackend.Domain.Exceptions
{
    /// <summary>
    /// Functional error handling
    /// </summary>
    public class HttpBusinessError
    {
        #region define

        private const string BAD_REQUEST = "400";

        #endregion

        /// <summary>
        /// Error status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Error timestamp.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Error code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Error details.
        /// </summary>
        public IEnumerable<HttpBusinessSubError> SubErrors { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public HttpBusinessError(CustomErrorCode code, string message, Dictionary<string, string> fields = null)
        {
            Status = BAD_REQUEST;
            Timestamp = DateTime.UtcNow;
            Code = code.ToString();
            Message = message;
            if (fields != null)
            {
                SubErrors = fields.Select(o => new HttpBusinessSubError
                {
                    Section = o.Key,
                    Field = o.Value
                });
            }
            else
            {
                SubErrors = null;
            }
        }
    }

    /// <summary>
    /// Error message details.
    /// </summary>
    public class HttpBusinessSubError
    {
        /// <summary>
        /// Error object.
        /// </summary>
        public string Section { get; set; }

        /// <summary>
        /// Error attribute.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Rejection code.
        /// </summary>
        public string RejectedValue { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public HttpBusinessSubError() { }
    }
}
