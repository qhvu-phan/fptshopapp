using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Dtos
{
    public class CreateProductDto
    {
        [Required]
        [StringLength(500, ErrorMessage = "Product name cannot exceed 500 characters.")]
        public string pro_name { get; set; }

        [Required]
        public double pro_price { get; set; }

        [Required]
        public int pro_quantity { get; set; }

        public string pro_description { get; set; }

        public string pro_sale { get; set; }

        [Required]
        public string pro_trademarkId { get; set; }

        [Required]
        public string pro_detailId { get; set; }
    }
}
