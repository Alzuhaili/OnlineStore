using OnineStore.Shared.Models.ProductModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineStore.Shared.Models.GeneralModels
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(35,MinimumLength =5,ErrorMessage ="Name should be between 5 and 35")]
        public string Name { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Description should be between 5 and 35")]
        public string Description { get; set; }
        [Url]
        public string ThumbnailURL { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
