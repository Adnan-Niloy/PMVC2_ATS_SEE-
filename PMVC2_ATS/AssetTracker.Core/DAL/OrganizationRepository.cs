using AssetTracker.Core.Context;
using AssetTracker.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AssetTracker.Core.DAL
{
    public class OrganizationRepository : IDisposable
    {
        private readonly AssetDbContext _context;

        public OrganizationRepository()
        {
            _context = new AssetDbContext();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public bool Add(Organization organization)
        {
            _context.Organizations.Add(organization);
            var rowAffected = _context.SaveChanges();

            return rowAffected > 0;
        }

        public IList<Organization> GetAll()
        {
            var organizations = _context.Organizations.Include(c => c.OrganizationBranches).ToList();
            return organizations;
        }


    }
}
