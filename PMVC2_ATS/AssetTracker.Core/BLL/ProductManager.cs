using AssetTracker.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class ProductManager
    {
        ProductRepository _repository = new ProductRepository();

        public IList<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public bool Add(Product product)
        {
            return _repository.Add(product);
        }
    }
}
