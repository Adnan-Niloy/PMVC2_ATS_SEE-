using AssetTracker.Core.DAL;
using AssetTracker.Core.Models;
using AssetTracker.Core.Models.Interfaces;
using System.Collections.Generic;
using AssetTracker.Core.Models.Interfaces.BaseInterface;
using System;
using AssetTracker.Core.Models.Interfaces.DAL;
using AssetTracker.Core.Models.Interfaces.BLL;

namespace AssetTracker.Core.BLL
{
    public class OrganizationManager : IOrganizationManager
    {
        private readonly IOrganizationRepository _repository;

        public OrganizationManager(IOrganizationRepository repository)
        {
            _repository = repository;
        }

        public bool Add(Organization organization)
        {
            if (organization == null)
                return false;

            if (organization.Code.Length != 3)
                return false;

            return _repository.Add(organization);
        }

        public ICollection<Organization> GetAll()
        {
               return _repository.GetAll();
        }

        public Organization GetById(int id)
        {
            return _repository.GetById(id);
        }

        public bool Update(Organization entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Organization> SearchByCriteria()
        {
            throw new NotImplementedException();
        }
    }
}
