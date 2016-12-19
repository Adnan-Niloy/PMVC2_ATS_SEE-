using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetTrackerWeb.Controllers
{
    public class ProductController : Controller
    {
        GeneralCategoryManager _GeneralCategoryManager = new GeneralCategoryManager();
        CategoryManager _categoryManager = new CategoryManager();
        SubCategoryManager _subCategoryManager = new SubCategoryManager();
        ProductManager _productManager = new ProductManager();
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.Product = GetAll();
            ViewBag.GeneralCategory = _GeneralCategoryManager.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Product Product)
        {
            if(Product == null)
            {
                return null;
            }
            bool productAdded = _productManager.Add(Product);
            return RedirectToAction("Index", "Product");
        }

        public IList<Product> GetAll()
        {
            return _productManager.GetAll();
        }

        public JsonResult GetByGeneralCategoryId(int? GeneralCategoryId)
        {
            if (GeneralCategoryId == null)
            {
                return null;
            }
            var category = _categoryManager.GetByGeneralCategoryId(GeneralCategoryId).Select
                (
                    c => new  {   c.Id, c.Name,c.Code, c.GeneralCategoryId }
                );
            return Json(category, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetByCategoryId(int? CategoryId)
        {
            if(CategoryId == null)
            {
                return null;
            }
            var subCategory = _subCategoryManager.GetByCategoryId(CategoryId).Select
                (
                    c => new { c.Id,c.Name,c.Code,c.CategoryId }
                );
            return Json(subCategory, JsonRequestBehavior.AllowGet);

        }
    }
}