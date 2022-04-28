using Labb3_API.Models;
using Labb3_API.Services;
using Labb3_API.Services.InterestService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InterestController : ControllerBase
    {
        private readonly IInterestService _interestService;

        public InterestController(IInterestService interestService)
        {
            _interestService = interestService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Interest>>>> GetAllInterests()
        {
            return Ok(await _interestService.GetAllInterestsAsync());
        }

        [HttpGet("{interestId:int}")]
        public async Task<ActionResult<ServiceResponse<Interest>>> GetInterest(int interestId)
        {
            return Ok(await _interestService.GetInterestAsync(interestId));
        }
 
        [HttpGet("byperson/{Id:int}")]
        public async Task<ActionResult<ServiceResponse<List<Interest>>>> GetInterestForPerson(int Id)
        {
            var interests = await _interestService.GetASpecificPersonsInterestsAsync(Id);
            return Ok(interests);
        }
    }
}
