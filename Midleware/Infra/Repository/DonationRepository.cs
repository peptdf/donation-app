using Midleware.Donation.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Donation.Infra.Repository
{
    public class DonationRepository : IRepositoryBase<Midleware.Donation.Domain.Model.Donation>, IDonationRepository
    {
        public void add(Midleware.Donation.Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Domain.Model.Donation> Getall()
        {
            throw new NotImplementedException();
        }

        public Domain.Model.Donation GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Domain.Model.Donation obj)
        {
            throw new NotImplementedException();
        }
    }
}
