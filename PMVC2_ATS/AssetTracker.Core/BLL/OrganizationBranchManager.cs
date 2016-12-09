using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class OrganizationBranchManager
    {
        private readonly OrganizationBranchRepository _repository = new OrganizationBranchRepository();

        public bool Add(OrganizationBranch organizationBranch)
        {
            if (organizationBranch.Organization != null && organizationBranch.Name != null &&
                organizationBranch.ShortName != null)
            {
                return _repository.Add(organizationBranch);
            }

            return false;
        }
    }
}
