using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.Models;
using AssetTracker.Core.BLL;
using AssetTrackerWeb.ViewModels;

namespace AssetTrackerWeb.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly SubCategoryManager _manager = new SubCategoryManager();
        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly GeneralCategoryManager _generalCategoryManager = new GeneralCategoryManager();
        // GET: SubCategory
        public ActionResult Entry()
        {
           // var subCategory = _manager.GetAll();
           
            
            return View();
        }

        [HttpPost]
        public ActionResult Entry(SubCategory subcategory)
        {
            var isAdded = _manager.Add(subcategory);
            return View();
        }

        //public IList<SubCategory> GetAll()
        //{
        //    var subCategory = _manager.GetAll();
        //    return subCategory.ToList();
        //}
    }
}