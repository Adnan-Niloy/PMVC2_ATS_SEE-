using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTrackerWeb.Controllers
{
    public class GeneralCategoryController : Controller
    {
        private readonly GeneralCategoryManager _manager = new GeneralCategoryManager();
        // GET: GeneralCategory

        public ActionResult Entry()
        {

            var generalCategory = _manager.GetAll();
            ViewBag.ModelGeneralCategory = generalCategory;
            return View();
        }

        [HttpPost]
        public ActionResult Entry(GeneralCategory generalCategory)
        {
            var isAdded = _manager.Add(generalCategory);
            if (isAdded)
                ViewBag.SuccessMessage = "General Category Created Successfully";
            else
                ViewBag.Error = "Failed to Save";
            return RedirectToAction("Entry", "GeneralCategory");
        }

       
    }
}