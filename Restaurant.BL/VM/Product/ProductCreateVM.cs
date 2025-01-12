using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BL.VM.Product
{
    public class ProductCreateVM
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
