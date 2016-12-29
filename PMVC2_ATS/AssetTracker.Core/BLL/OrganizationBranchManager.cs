using System;
using System.Collections.Generic;
using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;
using AssetTracker.Core.Models.Interfaces.BLL;

namespace AssetTracker.Core.BLL
{
    public class OrganizationBranchManager : IOrganizationBranchManager
    {
        private readonly OrganizationBranchRepository _repository;

        public OrganizationBranchManager(OrganizationBranchRepository repository)
        {
            _repository = repository;
        }
        public bool Add(OrganizationBranch organizationBranch)
        {
            if (organizationBranch.Name != null && organizationBranch.ShortName != null)
            {
                return _repository.Add(organizationBranch);
            }

            return false;
        }

        public ICollection<OrganizationBranch> GetAll()
        {
            return _repository.GetAll();
        }

        public OrganizationBranch GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(OrganizationBranch entity)
        {
            throw new NotImplementedException();
        }
    }
}
