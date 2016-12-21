using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.Models
{
    public class PurchaseOrderModel
    {
        public PurchaseOrder PurchaseOrder { get; set; }
        public PurchaseOrderDetail PurchaseOrderDetail { get; set; }
    }
}
