using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.Context;

namespace AssetTracker.Core.DAL
{
    class GeneralCategoryRepository : IDisposable
    {

        private readonly AssetDbContext _context;

        public GeneralCategoryRepository()
        {
            _context = new AssetDbContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        internal bool Add(GeneralCategory generalCategory)
        {
            _context.GeneralCategories.Add(generalCategory);
            var rowAffected = _context.SaveChanges();

            return rowAffected > 0;
        }

        public IList<GeneralCategory> GetAll()
        {
            var generalCategory = _context.GeneralCategories.ToList();
            return generalCategory;
        }
    }
}
