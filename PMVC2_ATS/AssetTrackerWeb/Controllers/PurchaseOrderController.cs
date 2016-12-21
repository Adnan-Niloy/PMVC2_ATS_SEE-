using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.Models;
using AssetTracker.Core.BLL;

namespace AssetTrackerWeb.Controllers
{
    public class PurchaseOrderController : Controller
    {
        VendorManager vendorManager = new VendorManager();
        // GET: PurchaseOrder
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(PurchaseOrder purchaseOrder)
        {
            return View();
        }
    }
}