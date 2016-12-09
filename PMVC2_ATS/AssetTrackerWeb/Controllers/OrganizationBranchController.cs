﻿using AssetTracker.Core.BLL;
using AssetTracker.Core.Models;
using AssetTrackerWeb.ViewModels;
using System.Web.Mvc;

namespace AssetTrackerWeb.Controllers
{
    public class OrganizationBranchController : Controller
    {
        private readonly OrganizationManager _manager = new OrganizationManager();
        private readonly OrganizationBranchManager _branchManager = new OrganizationBranchManager();

        public ActionResult Entry()
        {
            var organizations = _manager.GetAll();

            var viewModel = new OrganizationBranchViewModel
            {
                Organizations = organizations,
                OrganizationBranch = new OrganizationBranch()
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Entry(OrganizationBranch organizationBranch)
        {
            _branchManager.Add(organizationBranch);
            return RedirectToAction("Entry", "OrganizationBranch");
        }
    }
}