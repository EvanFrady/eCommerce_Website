using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Website.Models
{
    public class CategoryTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Category Type")]
        public string CategoryType { get; set; }

    }
}
