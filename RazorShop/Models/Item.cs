using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public Category Category { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [Range(1, 1000)]
        public double Price { get; set; }


    }
}
