using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Domain.Model
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }
        public string PersonType { get; set; }
    }
}
