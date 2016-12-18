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
            ViewBag._category = GetAll();
            var category = _categoryManager.GetAll();
            var generalCategory = _generalCategoryManager.GetAll();

            ViewBag.GeneralCategory = generalCategory;

            return View();
        }

        [HttpPost]
        public ActionResult Entry(SubCategory subcategory)
        {
            var isAdded = _manager.Add(subcategory);
            return RedirectToAction("Entry", "SubCategory");
        }

        public IList<SubCategory> GetAll()
        {
            var subCategory = _manager.GetAll();
            return subCategory.ToList();
        }

        public ActionResult GetByGeneralCategoryId(int? GeneralCategoryId)
        {
            if(GeneralCategoryId == null)
            {
                return null;
            }
            var category = _categoryManager.GetByGeneralCategoryId(GeneralCategoryId).Select
                (
                    c => new
                    {
                        c.Id,c.Name,c.Code,c.GeneralCategoryId
                    }
                );
            return Json(category, JsonRequestBehavior.AllowGet);
        }
    }
}