using System.Collections.Generic;
using Midleware.Domain.Model;
using Midleware.Domain.Repository;
using Midleware.Domain.Service.Contracts;

namespace Midleware.Domain.Service
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository ParticipantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            ParticipantRepository = participantRepository;
        }
    
        public void add(Participant obj)
        {
            ParticipantRepository.add(obj);
        }

        public IEnumerable<Participant> Getall()
        {
            return ParticipantRepository.Getall();
        }

        public Participant GetById(int id)
        {
            return ParticipantRepository.GetById(id);
        }

        public void Remove(int id)
        {
            ParticipantRepository.Remove(id);
        }

        public void Update(Participant obj)
        {
            ParticipantRepository.Update(obj);
        }
    }
}
