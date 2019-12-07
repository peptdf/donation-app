using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midleware.Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Donation.Controllers
{
    [Route("api/participant")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {

        private readonly IParticipantService _ParticipantService;

        public ParticipantController(IParticipantService _participantService)
        {
            _ParticipantService = _participantService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Midleware.Domain.Model.Participant>> Get()
        {
            return Ok(_ParticipantService.Getall());
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
