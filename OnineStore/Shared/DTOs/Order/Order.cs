using OnineStore.Shared.Models.GeneralModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.DTOs.Order
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public decimal Tax { get; set; }
        public decimal Amount { get; set; }
        public string ShippingAddress { get; set; }
        public DateTime DateTime { get; set; }
        public int Status { get; set; }

    }
}
