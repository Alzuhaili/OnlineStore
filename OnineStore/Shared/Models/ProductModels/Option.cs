using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.ProductModels
{
    public class Option
    {
        [Key]
        public int OptionId { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Name is required ...")]
        public string Name { get; set; }

        public virtual ICollection<ProductOption> ProductOptions { get; set; }

    }
}
