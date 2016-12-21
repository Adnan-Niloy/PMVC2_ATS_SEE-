using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class PurchaseOrderDetail
    {
        public int Id { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }
        public decimal TotalPrice { get; set; }
        public float WarrantyPeriod { get; set; }
        public int Serial { get; set; }
        public string Description { get; set; }

        public int PurchaseOrderId { get; set; }
        public int ProductId { get; set; }

        public PurchaseOrder PurchaseOrder { get; set; }
        public Product Product { get; set; }
    }
}
