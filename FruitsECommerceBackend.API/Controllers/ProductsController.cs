using FruitsECommerceBackend.Application.Viewmodels;
using FruitsECommerceBackend.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FruitsECommerceBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        //private readonly IProductService _productService;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProductsController(
            //IProductService productService
            )
        {
            //_productService = productService;
        }

        /// <summary>
        /// Get products by filtered criteria
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="category"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Product>> GetAll(
            [FromQuery(Name = "product-name")] string productName,
            [FromQuery(Name = "category")] string category,
            [FromQuery] int limit = 50,
            [FromQuery] int offset = 0)
        {
            try
            {
                const int MAX_LIMIT = 100;
                if (offset < 0)
                {
                    return BadRequest(new HttpBusinessError(CustomErrorCode.OFFSET_NEGATIVE, "Offset must be a non-negative number"));
                }
                if (limit < 1)
                {
                    return BadRequest(new HttpBusinessError(CustomErrorCode.LIMIT_NONPOSITIVE, "Limit must be a positive number"));
                }

                // TODO: complete service call
                IEnumerable<Product> products = new List<Product>();

                return Ok(products);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }

        /// <summary>
        /// Get a product information by its ID
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Product>> Get(int productId)
        {
            try
            {
                // TODO: complete service call
                Product product = new Product();

                return Ok(product);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }
    }
}
