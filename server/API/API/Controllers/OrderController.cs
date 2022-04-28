using EncommerceMongoDB.core.Dtos;
using EncommerceMongoDB.core.Models;
using EncommerceMongoDB.core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("create")]
        public async Task<IActionResult> AddOrder(CreateOrderDto request)
        {
            var order = new Order()
            {
                order_price = request.order_price,
                order_pro_id = request.order_pro_id,
                order_status = request.order_status
            };

            await _orderService.AddOrderAsync(order);

            return Ok();
        }


        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetOrderById(string id)
        {
            var order = await _orderService.GetOrderAsync(id);
            return Ok(order);
        }        
        
        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateOrder(string id, UpdateOrderDto request)
        {
            var order = await _orderService.UpdateOrderAsync(request);
            return Ok(order);
        }

    }
}
