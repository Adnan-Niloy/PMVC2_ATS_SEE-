using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AssetTracker.Core.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is Required")]
        public string Name { get; set; }
        [StringLength(int.MaxValue,MinimumLength = 10)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Mobile is required")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Envalid Email Address")]
        public string Email { get; set; }
        public bool Status { get; set; }

    }
}
