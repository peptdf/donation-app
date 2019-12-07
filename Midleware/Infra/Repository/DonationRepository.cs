using Midleware.Domain.Repository;
using System;
using System.Collections.Generic;

namespace Midleware.Donation.Infra.Repository
{
    public class DonationRepository : IDonationRepository
    {
        public void add(Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Model.Donation> Getall()
        {
            throw new NotImplementedException();
        }

        public Domain.Model.Donation GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }
    }
}
