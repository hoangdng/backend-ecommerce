using FruitsECommerceBackend.Application.Viewmodels;
using FruitsECommerceBackend.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FruitsECommerceBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CartsController : ControllerBase
    {
        //private readonly ICartService _cartService;

        /// <summary>
        /// Constructor
        /// </summary>
        public CartsController(
            //ICartService cartService
            )
        {
            //_cartService = cartService;
        }

        /// <summary>
        /// Get products by filtered criteria
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="category"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Cart> Update(int cartId, Cart cart)
        {
            try
            {
                // TODO: complete service call
                Cart updatedCart = new Cart();

                return Ok(updatedCart);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }

        /// <summary>
        /// Get a cart information by its ID
        /// </summary>
        /// <param name="cartId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Cart> Get(int cartId)
        {
            try
            {
                // TODO: complete service call
                Cart cart = new Cart();

                return Ok(cart);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }
    }
}
