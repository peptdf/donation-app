using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midleware.Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Donation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IDonationService _DonationService;

        public ValuesController(IDonationService _donationService)
        {
            _DonationService = _donationService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Midleware.Domain.Model.Donation>> Get()
        {
            return Ok(_DonationService.Getall());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
