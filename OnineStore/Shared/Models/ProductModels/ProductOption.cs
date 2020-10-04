using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.ProductModels
{
    public class ProductOption
    {
        public int OptionId { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("OptionId")]
        public virtual Option Option { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
