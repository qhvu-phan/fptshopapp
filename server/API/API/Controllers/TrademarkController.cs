using EncommerceMongoDB.core;
using EncommerceMongoDB.core.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrademarkController : ControllerBase
    {

        private readonly ITrademarkServices _trademarkServices;
        public TrademarkController(ITrademarkServices tradeServices)
        {
            _trademarkServices = tradeServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetTrademarks()
        {
            return Ok(( await _trademarkServices.GetTrademarksAsync() ).Select(trademark => trademark.Trademark_Dto()));
        }

        [HttpGet("{Id}", Name = "GetTrademark")]
        public async Task<IActionResult> GetTrademark(string Id)
        {
            try
            {
                var trademark = await _trademarkServices.GetTrademarkAsync(Id);

                if (trademark is null)
                {
                    return NotFound();
                }

                return Ok(trademark);
            }
            catch
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddTrademark(CreateTrademarkDto trademark_dto)
        {
            var trademark = new Trademark
            {
                trade_name = trademark_dto.trade_name,
                create_date = DateTime.Now
            };

            await _trademarkServices.AddTrademarkAsync(trademark);

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteTrademark(string Id)
        {
            try
            {
                await _trademarkServices.DeleteTrademarkAsync(Id);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateTrademark(string Id, UpdateTrademarkDto ud_trademark)
        {
            try
            {
                var trademark = await _trademarkServices.GetTrademarkAsync(Id);

                if (trademark is null)
                {
                    return NotFound();
                }

                trademark.trade_name = ud_trademark.trade_name;

                await _trademarkServices.UpdateTrademarkAsync(trademark);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
   
        }
    }
}
