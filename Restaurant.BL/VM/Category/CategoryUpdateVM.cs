using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BL.VM.Category
{
    public class CategoryUpdateVM
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
