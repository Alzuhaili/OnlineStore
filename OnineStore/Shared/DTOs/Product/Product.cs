using OnineStore.Shared.Models.GeneralModels;
using OnineStore.Shared.Models.OrderModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.DTOs.Product
{
    public class Product
    {
        public int ProductId { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Weight { get; set; }

    }
}
