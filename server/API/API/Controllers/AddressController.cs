using EncommerceMongoDB.core.Dtos;
using EncommerceMongoDB.core.Models;
using EncommerceMongoDB.core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressServices _addressServices;

        public AddressController(IAddressServices addressServices)
        {
            _addressServices = addressServices;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetAddressById(string Id)
        {
            try
            {
                return Ok(await _addressServices.GetAddressByIdAsync(Id));
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAddress(CreateAddressDto address_dto)
        {
            var address = new Address
            {
                details = address_dto.address_Details,
                create_date = DateTime.Now
            };

            await _addressServices.AddNewAddressAsync(address);

            return NoContent();
        }

       
    }
}
