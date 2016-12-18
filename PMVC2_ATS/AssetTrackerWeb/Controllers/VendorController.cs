using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.Models;
using AssetTracker.Core.BLL;

namespace AssetTrackerWeb.Controllers
{
    public class VendorController : Controller
    {
        VendorManager _manager = new VendorManager();
        // GET: Vendor
        public ActionResult Index()
        {
            ViewBag.Vendor = GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult Index(Vendor Vendor)
        {
            var isAdded = _manager.Add(Vendor);
            if (isAdded)
                ViewBag.SuccessMessage = "General Category Created Successfully";
            else
                ViewBag.Error = "Failed to Save";
            return RedirectToAction("Index", "Vendor");
        }

        public List<Vendor> GetAll()
        {
            return _manager.GetAll();
        }
    }
}