using Midleware.Donation.Domain.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Donation.Domain.Service
{
    public class DonationService : IDonationService
    {
        public string[] getValues()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
