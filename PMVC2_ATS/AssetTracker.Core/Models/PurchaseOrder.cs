using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class PurchaseOrder
    {
        [Key]
        public int Id { get; set; }
        public string ReferenceName { get; set; }
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public int VendorId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Vendor Vendor { get; set; }
        public virtual Employee Employee { get; set; }

        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        //public virtual ICollection<PurchaseFile> PurchaseFiles { get; set; }
    }
}
