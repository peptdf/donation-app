using Midleware.Donation.Domain.Model;
using Midleware.Donation.Domain.Repository;
using System;
using System.Collections.Generic;

namespace Donation.Infra.Repository
{
    public class ParticipantRepository : IRepositoryBase<Participant>, IParticipantRepository
    {
        public void add(Participant obj)
        {
           throw new NotImplementedException();
        }

        public IEnumerable<Participant> Getall()
        {
            throw new NotImplementedException();
        }

        public Participant GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Participant obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Participant obj)
        {
            throw new NotImplementedException();
        }
    }
}
