using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class VendorManager
    {
        VendorRepository _repository = new VendorRepository();

        public List<Vendor> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Add(Vendor vendor)
        {
            return _repository.Add(vendor);
           
        }
    }
}
