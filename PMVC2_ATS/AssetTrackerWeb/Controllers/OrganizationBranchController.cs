using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;
using AssetTrackerWeb.ViewModels;
using System.Web.Mvc;
using AssetTracker.Core.Models.Interfaces.BLL;
using System.Collections.Generic;
using System.Linq;

namespace AssetTrackerWeb.Controllers
{
    public class OrganizationBranchController : Controller
    {
        private readonly IOrganizationManager _manager;
        private readonly IOrganizationBranchManager _branchManager;

        public OrganizationBranchController(IOrganizationBranchManager branchManager, IOrganizationManager manager)
        {
            _manager = manager;
            _branchManager = branchManager;
        }

        public ActionResult Entry()
        {
            var organizations = _manager.GetAll();

            var viewModel = new OrganizationBranchViewModel
            {
                Organizations = organizations,
                OrganizationBranch = new OrganizationBranch()
            };

            ViewBag.OrganizationBranch = GetAll();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Entry(OrganizationBranch organizationBranch)
        {
            _branchManager.Add(organizationBranch);
            return RedirectToAction("Entry", "OrganizationBranch");
        }


        public List<OrganizationBranch> GetAll()
        {
            var OrgBranch = _branchManager.GetAll();
            return OrgBranch.ToList() ;
        }
    }
}