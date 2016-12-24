using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.Models;
using AssetTracker.Core.BLL;
using AutoMapper;


namespace AssetTrackerWeb.Controllers
{
    public class PurchaseOrderController : Controller
    {
        VendorManager vendorManager = new VendorManager();
        ProductManager productManager = new ProductManager();
        PurchaseOrderManager _manager = new PurchaseOrderManager();

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
            ViewBag.Vendor = vendorManager.GetAll();
            ViewBag.Product = productManager.GetAll();

            var model = new PurchaseOrder();

            if (!ModelState.IsValid) return View(model);

            var puchaseReg = Mapper.Map<PurchaseOrder>(model);

            bool isSaved = _manager.Add(puchaseReg);
            if (isSaved)
            {
                return RedirectToAction("Index");
            }
            return View(model);

        }
    }
}