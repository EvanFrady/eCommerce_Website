using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_Website.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


        [Required]
        public decimal Price { get; set; }


        public string Image { get; set; }


        [Display(Name = "Product Color")]
        public string ProductColor { get; set; }


        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }


        [Display(Name = "Category Type")]
        [Required]
        public int CategoryTypeId { get; set; }


        [ForeignKey("CategoryTypeId")]
        public CategoryTypes CategoryTypes { get; set; }

    }
}
