using System.Net;

namespace FruitsECommerceBackend.Domain.Exceptions
{
    /// <summary>
    /// Customized functional exception.
    /// </summary>
    public class HttpBusinessException : HttpRequestException
    {
        /// <summary>
        /// Error code.
        /// </summary>
        public CustomErrorCode Code { get; set; }

        /// <summary>
        /// Error Status.
        /// </summary>
        public HttpStatusCode Status { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        public string Value { get; set; }

        #region constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="status">HTTP status code</param>
        /// <param name="message">Error message</param>
        public HttpBusinessException(CustomErrorCode code, HttpStatusCode status, string message) : base(message)
        {
            Code = code;
            Status = status;
            Value = message;
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="status">HTTP status code</param>
        public HttpBusinessException(CustomErrorCode code, HttpStatusCode status) : base()
        {
            Code = code;
            Status = status;
            Value = code.ToString();
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        public HttpBusinessException(string message) : base(message)
        {
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Exception</param>
        public HttpBusinessException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// constructor.
        /// </summary>
        public HttpBusinessException() : base() { }

        #endregion
    }
}
