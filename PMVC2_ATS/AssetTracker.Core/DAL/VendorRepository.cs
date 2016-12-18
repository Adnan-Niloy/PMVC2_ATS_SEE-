using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
    public class VendorRepository
    {
        AssetDbContext _context = new AssetDbContext();

        internal List<Vendor> GetAll()
        {
            var vendor = _context.Vendors.ToList();

            return vendor;
        }

        internal bool Add(Vendor vendor)
        {
            _context.Vendors.Add(vendor);
            var row = _context.SaveChanges();
            return row > 0;

        }
    }
}
