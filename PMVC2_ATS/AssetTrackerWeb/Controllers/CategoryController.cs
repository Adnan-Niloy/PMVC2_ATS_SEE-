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

    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager = new CategoryManager();
        private readonly GeneralCategoryManager _generalCategoryManager = new GeneralCategoryManager();
        // GET: Category
        public ActionResult Entry()
        {
            var generalCategory = _generalCategoryManager.GetAll();

            var category = GetAll();
                
                            //GetAll().Join(generalCategory,
                            //    c => c.GeneralCategoryId,
                            //    g => g.Id,
                            //    (c,g) =>
                            //    new
                            //    {
                            //        Id = c.Id,
                            //        Name = c.Name,
                            //        Code = c.Code,
                            //        Description = c.Description,
                            //        GeneralCategoryName = g.Name
                            //    }
                            //);


            ViewBag.allCategory = category;

            var viewModel = new CategoryViewModel
            {
                GeneralCategories = generalCategory,
                Category = new Category()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Entry(Category category)
        {
            _categoryManager.Add(category);
            return RedirectToAction("Entry", "Category");
        }

        public IList<Category> GetAll()
        {

            var Category = _categoryManager.GetAll();
            return Category;
        }
    }
}