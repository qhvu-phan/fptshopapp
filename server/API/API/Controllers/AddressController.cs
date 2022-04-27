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
        public async Task<IActionResult> GetAddressByIdAsync(string Id)
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
        public async Task<IActionResult> AddAddressAsync(CreateAddressDto address_dto)
        {
            var address = new Address
            {
                details = address_dto.address_Details,
                create_date = DateTime.Now
            };

            await _addressServices.AddNewAddressAsync(address);

            return NoContent();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateAddressAsync(string Id,UpdateAddressDto addressDto)
       { 
            try
            {
                var address = await _addressServices.GetAddressByIdAsync(Id);

                address.details = addressDto.addressDetails;
                address.update_date = DateTime.Now;

                await _addressServices.UpdateAddressAsync(address);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
       }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteAddressAsync(string Id)
        {
            try
            {
                var address = await _addressServices.GetAddressByIdAsync(Id);

                await _addressServices.DeleteAddressAsync(address);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}
