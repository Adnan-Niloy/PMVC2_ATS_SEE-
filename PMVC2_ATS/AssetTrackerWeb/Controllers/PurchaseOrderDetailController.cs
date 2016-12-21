using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;

namespace AssetTrackerWeb.Controllers
{
    public class PurchaseOrderDetailController : Controller
    {
        ProductManager productManager = new ProductManager();
        // GET: PurchaseOrderDetail
        public ActionResult Index()
        {
            return View();
        }

      
    }
}