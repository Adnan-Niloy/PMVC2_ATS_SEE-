using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker.Core.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }

        public int BranchId { get; set; }
        public OrganizationBranch Branch { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
