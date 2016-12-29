using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;
using System.Web.Mvc;
using AssetTracker.Core.Models.Interfaces.BLL;
using System.Linq;
using System.Collections.Generic;

namespace AssetTrackerWeb.Controllers
{
    public class OrganizationController : Controller
    {
        public  IOrganizationManager _manager;

        public  OrganizationController(IOrganizationManager manager)
        {
            _manager = manager;
        }

        public ActionResult Entry()
        {
            var organization = new Organization();
            ViewBag.Organization = GetAll();
            return View(organization);
        }

        [HttpPost]
        public ActionResult Entry(Organization organization)
        {
            var isAdded = _manager.Add(organization);

            if (isAdded)
                ViewBag.SuccessMessage = "Organization Created Successfully";

            ViewBag.ErrorMessage = "Organization Creation Failed";

            return RedirectToAction("Entry", "Organization");
        }

        public List<Organization> GetAll()
        {
            List<Organization> organizations = _manager.GetAll().ToList();
            return organizations;
        }
    }
}