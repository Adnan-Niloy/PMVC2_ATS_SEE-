using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class GeneralCategoryManager
    {
        private readonly GeneralCategoryRepository _repository = new GeneralCategoryRepository();

        public bool Add(GeneralCategory generalCategory)
        {
            if(generalCategory==null)
            {
                return false;
            }

            return _repository.Add(generalCategory);
        }

        public IList<GeneralCategory> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
