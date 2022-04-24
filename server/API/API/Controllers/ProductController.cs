using EncommerceMongoDB.core;
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
    public class ProductController : Controller
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices proServices)
        {
            _productServices = proServices;
        }

        // get or search products
        [Route("GetProducts")]
        [HttpGet]
        public async Task<IActionResult> GetProducts(string search)
        {
            var products = await _productServices.GetProductsAsync();

            if(!string.IsNullOrEmpty(search))
            {
                products = await _productServices.SearchProducts(search) ;
            }

            return Ok( products.OrderByDescending(pro => pro.pro_createDate).Select(product => product.Product_Dto()));
        }

        [HttpGet("{Id}", Name = "GetProduct")]
        public async Task<IActionResult> GetProduct(string Id)
        {
            try
            {
                var product = await _productServices.GetProductAsync(Id);
                
                if (product is null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch
            {
                return NotFound();
            }

        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductDto createProductDto)
        {
            var product = new Product
            {
                pro_name = createProductDto.pro_name,
                pro_price = createProductDto.pro_price,
                pro_description = createProductDto.pro_description,
                pro_quantity = createProductDto.pro_quantity,
                pro_sale = createProductDto.pro_sale,
                pro_trademarkId = createProductDto.pro_trademarkId,
                pro_detailId = createProductDto.pro_detailId,
                pro_active = true,
                pro_createDate = DateTime.Now
            };

            await _productServices.AddProductAsync(product);

            return NoContent();
        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateProduct(string Id, UpdateProductDto productDto)
        {
            try 
            {
                var product = await _productServices.GetProductAsync(Id);

                if (product is null)
                {
                    return NotFound();
                }

                product.pro_name = productDto.pro_name;
                product.pro_price = productDto.pro_price;
                product.pro_description = productDto.pro_description;
                product.pro_quantity = product.pro_quantity;
                product.pro_sale = productDto.pro_sale;
                product.pro_trademarkId = productDto.pro_trademarkId;
                product.pro_updateDate = DateTime.Now;
                product.pro_detailId = productDto.pro_detailId;

                await _productServices.UpdateProductAsync(product);
                return NoContent();
            } 
            catch
            {
                return NotFound(); 
            }
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProduct(string Id)
        {
            try
            {
                var product = await _productServices.GetProductAsync(Id);

                await _productServices.DeleteProductAsync(product);
                return NoContent();
            }
            catch
            {
                return NotFound();
            }
        }

        // get products by id of trademark and page number 
        [Route("GetProducts/Trademark/{Id}/Page/{page}")]
        [HttpGet]
        public async Task<IActionResult> GetProductsByIdOfTrademark(string Id,int page)
        {
            try
            {
                var Result = await _productServices.GetProductsById_Trademark(Id);
                return Ok(Result.OrderByDescending(pro => pro.pro_createDate).Skip((page-1)*4).Take(4));
            }
            catch
            {
                return NotFound();
            }
        }



    }
}
