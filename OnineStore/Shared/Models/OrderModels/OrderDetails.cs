using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.OrderModels
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }
        public int Quantity { get; set; }
    }
}
