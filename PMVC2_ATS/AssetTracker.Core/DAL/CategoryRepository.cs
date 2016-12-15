using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Context;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.DAL
{
    public class CategoryRepository:IDisposable
    {
        private readonly AssetDbContext _context = new AssetDbContext();
        public bool Add(Category category)
        {
            _context.Categories.Add(category);
            var rowAffected = _context.SaveChanges();

            return rowAffected > 0;
        }

        internal IList<Category> GetAll()
        {
            var category = _context.Categories.ToList();
            return category;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
