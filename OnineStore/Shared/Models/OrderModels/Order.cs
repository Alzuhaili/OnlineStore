using OnineStore.Shared.Models.GeneralModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.OrderModels
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal Tax { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        [StringLength(255,ErrorMessage ="Shipping Address is required")]
        public string ShippingAddress { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public int Status { get; set; }


        // 1 Customer
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<ProductModels.ProductOption> ProductOptions { get; set; }

    }
}
