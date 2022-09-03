using FruitsECommerceBackend.Application.Viewmodels;
using FruitsECommerceBackend.Domain.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FruitsECommerceBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        //private readonly IOrderService _orderService;

        /// <summary>
        /// Constructor
        /// </summary>
        public OrdersController(
            //IOrderService orderService
            )
        {
            //_orderService = orderService;
        }

        /// <summary>
        /// Create a new order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Order> Create(Order order)
        {
            try
            {
                // TODO: complete service call
                Order createdOrder = new Order();

                return Ok(createdOrder);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }

        /// <summary>
        /// Get orders by filtered criteria
        /// </summary>
        /// <param name="customerId"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<IEnumerable<Order>> GetAll(
            [FromQuery(Name = "customer-id")] int customerId,
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
                IEnumerable<Order> order = new List<Order>();

                return Ok(order);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }

        /// <summary>
        /// Get order information by its ID
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<Order> Get(int orderId)
        {
            try
            {
                // TODO: complete service call
                Order order = new Order();

                return Ok(order);
            }
            catch (HttpBusinessException e)
            {
                return BadRequest(new HttpBusinessError(e.Code, e.Message));
            }
        }
    }
}
