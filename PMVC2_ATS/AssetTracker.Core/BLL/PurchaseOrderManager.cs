using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.DAL;

namespace AssetTracker.Core.BLL
{
    public class PurchaseOrderManager
    {
        PurchaseOrderRepository _repository = new PurchaseOrderRepository();

        public bool Add(PurchaseOrder purchaseOrder)
        {
            return _repository.Add(purchaseOrder);
        }
    }
}
