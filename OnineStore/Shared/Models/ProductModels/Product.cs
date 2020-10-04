using OnineStore.Shared.Models.GeneralModels;
using OnineStore.Shared.Models.OrderModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.ProductModels
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(25,MinimumLength =25,ErrorMessage = "SKU must be 25 chars")]
        public string SKU { get; set; }
        [Required]
        [StringLength(20,ErrorMessage = "Name is required and less than 20")]
        public string Name { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Description is required and less than 50")]
        public string Description { get; set; }
        [Required]
        [Range(0.0,100000)]
        public decimal Price { get; set; }
        [Required]
        public decimal Weight { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductOption> ProductOptions { get; set; }

    }
}
