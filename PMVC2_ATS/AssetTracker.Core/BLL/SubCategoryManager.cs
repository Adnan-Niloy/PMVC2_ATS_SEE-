using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.DAL;

namespace AssetTracker.Core.BLL
{
    public class SubCategoryManager
    {
        private readonly SubCategoryRepository _repository = new SubCategoryRepository();

        public bool Add(SubCategory subcategory)
        {
            return _repository.Add(subcategory);
        }

        //public IList<SubCategory> GetAll()
        //{
        //    return _repository.GetAll();
        //}
    }
}
