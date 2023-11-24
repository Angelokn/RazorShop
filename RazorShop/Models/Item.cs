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
        public string Category { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Price { get; set; }


    }
}
