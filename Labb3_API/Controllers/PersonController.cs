using System.Net;
using Labb3_API.Models;
using Labb3_API.Services;
using Labb3_API.Services.PersonService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPersons()
        {
            var persons = await _personService.GetPersonsAsync();
            return Ok(persons);
        }

        [HttpGet("{personId:int}")]
        public async Task<ActionResult<ServiceResponse<List<Person>>>> GetPerson(int personId)
        {
            var person = await _personService.GetPersonAsync(personId);
            return Ok(person);
        }

        [HttpPut("updateinterest/{personID:int}")]
        public async Task<ActionResult<ServiceResponse<Person>>> UpdateAPersonsInterest(int personID, Interest interestObject)
        {
            var person = await _personService.AddAInterestToAPerson(personID, interestObject);
            return Ok(person);
        }

        [HttpPut("addlink/{personID}/{interestId}")]
        public async Task<ActionResult<ServiceResponse<Person>>> AddLinks(int personID, int interestId, Link linkObject)
        {
            var person = await _personService.AddNewLinksToPerson(personID, interestId, linkObject);
            return Ok(person);
        }
    }
}
