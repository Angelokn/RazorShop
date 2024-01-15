using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorShop.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(35)]
        [DisplayName("Product Name")]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public int CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        [ValidateNever]
        public Category Category { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 1000)]
        public double Price { get; set; }


    }
}
