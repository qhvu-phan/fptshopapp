using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core.Dtos
{
    public class UpdateTrademarkDto
    {
        [Required]
        [StringLength(20, ErrorMessage = "Trademark name cannot exceed 20 characters.")]
        public string trade_name { get; set; }
    }
}
