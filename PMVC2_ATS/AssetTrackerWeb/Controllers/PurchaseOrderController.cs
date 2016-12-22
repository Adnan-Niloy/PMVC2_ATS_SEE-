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
        ProductManager productManager = new ProductManager();
        // GET: PurchaseOrder
        public ActionResult Index()
        {
            ViewBag.Vendor = vendorManager.GetAll();
            ViewBag.Product = productManager.GetAll();

            var model = new PurchaseOrder();
            return View();
        }
        [HttpPost]
        public ActionResult Index(PurchaseOrder purchaseOrder)
        {
            return View();
        }
    }
}