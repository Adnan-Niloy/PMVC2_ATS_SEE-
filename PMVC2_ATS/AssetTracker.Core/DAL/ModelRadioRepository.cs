using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.Context;



namespace AssetTracker.Core.DAL
{
    public class ModelRadioRepository
    {
        private readonly AssetDbContext _context = new AssetDbContext();

        public IList<ModelForRadio> GetGeneralCategory()
        {
            var _gCategory = (from r in _context.GeneralCategories
                              select new ModelForRadio { Id = r.Id, Name = r.Name }).ToList();
            return _gCategory;

        }
    }
}
