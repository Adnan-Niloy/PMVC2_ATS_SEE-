using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTrackerWeb.Controllers
{
    public class PurchaseOrderModelController : Controller
    {
        List<PurchaseOrderDetail> PurchaseOrderDetail2 = new List<PurchaseOrderDetail>();
        ProductManager productManager = new ProductManager();
        VendorManager vendorManager = new VendorManager();
        // GET: PurchaseOrderModel

        public ActionResult Index()
        {
            ViewBag.Vendor = vendorManager.GetAll();
            ViewBag.Product = productManager.GetAll();

            ViewBag.PurchaseDetail = PurchaseOrderDetail2;

            return View();
        }
        [HttpPost]
        public ActionResult Index(PurchaseOrderModel PurchaseOrderModel)
        {
           
            ViewBag.Vendor = vendorManager.GetAll();
            ViewBag.Product = productManager.GetAll();

            ViewBag.PurchaseDetail = PurchaseOrderDetail2;
            return View();
        }

        public ActionResult CreatePurchaseOrder(PurchaseOrderDetail PurchaseOrderDetail)
        {
            PurchaseOrderDetail2.Add(PurchaseOrderDetail);
            return RedirectToAction("Index");
        }
    }
}