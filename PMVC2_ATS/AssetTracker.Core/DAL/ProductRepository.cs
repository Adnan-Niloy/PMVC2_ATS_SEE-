using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
    public class ProductRepository
    {
        AssetDbContext _context = new AssetDbContext();

        internal IList<Product> GetAll()
        {
            var product = _context.Products.ToList();
            return product;
        }

        internal bool Add(Product product)
        {
            _context.Products.Add(product);
            var rowAffected = _context.SaveChanges();
            return rowAffected > 0;
        }
    }
}
