using AssetTracker.Core.Context;
using AssetTracker.Core.Models;
using System;

namespace AssetTracker.Core.DAL
{
    public class OrganizationBranchRepository : IDisposable
    {
        private readonly AssetDbContext _context;

        public OrganizationBranchRepository()
        {
            _context = new AssetDbContext();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public bool Add(OrganizationBranch organizationBranch)
        {
            _context.OrganizationBranches.Add(organizationBranch);
            var rowAffected = _context.SaveChanges();

            return rowAffected > 0;
        }
    }
}
