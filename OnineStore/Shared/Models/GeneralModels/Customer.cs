using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.GeneralModels
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(35,ErrorMessage ="Fullname is required")]
        public string FullName { get; set; }
        public string DefaultShippingAddress { get; set; }
        [Required]
        [StringLength(20,ErrorMessage ="Country is required")]
        public string Country { get; set; }

        // Many orders
        public virtual ICollection<OrderModels.Order> Orders { get; set; }
    }
}
