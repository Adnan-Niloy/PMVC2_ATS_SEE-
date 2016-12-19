using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{

    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
