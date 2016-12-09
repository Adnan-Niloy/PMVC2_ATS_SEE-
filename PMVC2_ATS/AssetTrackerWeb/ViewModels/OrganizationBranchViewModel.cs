using AssetTracker.Core.Models;
using System.Collections.Generic;

namespace AssetTrackerWeb.ViewModels
{
    public class OrganizationBranchViewModel
    {
        public OrganizationBranch OrganizationBranch { get; set; }
        public ICollection<Organization> Organizations { get; set; }

    }
}