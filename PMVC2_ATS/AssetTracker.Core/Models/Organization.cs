using System.Collections.Generic;

namespace AssetTracker.Core.Models
{
    public class Organization
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Location { get; set; }

        public ICollection<OrganizationBranch> OrganizationBranches { get; set; }

    }
}
