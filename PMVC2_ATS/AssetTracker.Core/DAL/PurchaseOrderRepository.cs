using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
    public class PurchaseOrderRepository
    {
        AssetDbContext _context = new AssetDbContext();

        public bool Add(PurchaseOrder purchaseOrder)
        {
            _context.PurchaseOrders.Add(purchaseOrder);
            var row = _context.SaveChanges();

            return row > 0;
        }
    }
}
