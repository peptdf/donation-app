using Midleware.Domain.Model;
using Midleware.Domain.Repository;
using Midleware.Infra.Database;
using System;
using System.Collections.Generic;

namespace Donation.Infra.Repository
{
    public class ParticipantRepository : IParticipantRepository
    {
        public void add(Participant obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Participant> Getall()
        {
            var Params = new Dapper.DynamicParameters();

            Params.Add("@StatementType", "SELECT");

            using (var db = new DbManager()) {
                return db.ExecuteProcedure<Participant>("dbo.jp_ParticipantAction", Params);
            }
        }

        public Participant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Participant obj)
        {
            throw new NotImplementedException();
        }
    }
}
