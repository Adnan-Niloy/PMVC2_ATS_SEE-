using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;

namespace AssetTracker.Core.BLL
{
    public class OrganizationManager
    {
        private readonly OrganizationRepository _repository = new OrganizationRepository();

        public bool Add(Organization organization)
        {
            if (organization == null)
                return false;

            if (organization.Code.Length != 3)
                return false;

            return _repository.Add(organization);
        }
    }
}
