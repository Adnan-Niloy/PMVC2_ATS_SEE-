using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.Context;

namespace AssetTracker.Core.DAL
{
    public class SubCategoryRepository:IDisposable
    {
        private readonly AssetDbContext _context = new AssetDbContext();

        public bool Add(SubCategory subcategory)
        {
            _context.SubCategories.Add(subcategory);

            var rowAffected = _context.SaveChanges();
            return rowAffected > 0;

        }

        public IList<SubCategory> GetAll()
        {
            var SubCategory = _context.SubCategories;
            return SubCategory.ToList();
        }

        internal IList<SubCategory> GetByCategoryId(int? categoryId)
        {
            var SubCategory = _context.SubCategories.Where(c=>c.CategoryId==categoryId);
            return SubCategory.ToList() ;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    
    }
}
