using Midleware.Donation.Domain.Repository;
using System;
using System.Collections.Generic;

namespace Donation.Infra.Repository
{
    public class RepositoryBase : IRepositoryBase<Midleware.Donation.Domain.Model.Donation>
    {
        public void add(Midleware.Donation.Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Midleware.Donation.Domain.Model.Donation> Getall()
        {
            throw new NotImplementedException();
        }

        public Midleware.Donation.Domain.Model.Donation GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Midleware.Donation.Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Midleware.Donation.Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }
    }
}
