using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Dtos
{
    public class UpdateAddressDto
    {
        [Required]
        public string addressDetails { get; set; }
    }
}
