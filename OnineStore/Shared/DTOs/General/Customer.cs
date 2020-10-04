using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.DTOs.General
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string DefaultShippingAddress { get; set; }
        public string Country { get; set; }
    }
}
