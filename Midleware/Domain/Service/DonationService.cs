using Midleware.Domain.Model;
using Midleware.Domain.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midleware.Domain.Service
{
    public class DonationService : IDonationService
    {
        private readonly IDonationService _donationService;

        public DonationService(IDonationService donationService)
        {
            _donationService = donationService;
        }

        public void add(Model.Donation obj)
        {
            _donationService.add(obj);
        }

        public IEnumerable<Model.Donation> Getall()
        {
            return _donationService.Getall();
        }

        public Model.Donation GetById(int id)
        {
            return _donationService.GetById(id);
        }

        public void Remove(int id)
        {
            _donationService.Remove(id);
        }

        public void Update(Model.Donation obj)
        {
            _donationService.Update(obj);
        }
    }
}
