using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Domain.Model
{
    public class Donation
    {
        public string DonationType { get; set; }
        public string ParticipantDonorId { get; set; }
        public string ParticipantBeneficiaryId { get; set; }
        public string DonationDescription { get; set; }
        public DateTime DonationDate { get; set; }
    }
}
