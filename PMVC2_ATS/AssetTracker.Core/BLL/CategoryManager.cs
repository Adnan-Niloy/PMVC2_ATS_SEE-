using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.DAL;

namespace AssetTracker.Core.BLL
{

    public class CategoryManager
    {
        private readonly CategoryRepository _repository = new CategoryRepository();
        public bool Add(Category category)
        {

            return _repository.Add(category);
        }

        public IList<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public List<Category> GetByGeneralCategoryId(int? generalCategoryId)
        {
            if(generalCategoryId == null)
            {
                return null;
            }

            return _repository.GetByGeneralCategoryId(generalCategoryId);
        }
    }
}
