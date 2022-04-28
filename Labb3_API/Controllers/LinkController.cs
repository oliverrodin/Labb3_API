using Labb3_API.Models;
using Labb3_API.Services;
using Labb3_API.Services.LinkService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labb3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkService _linkService;

        public LinkController(ILinkService linkService)
        {
            _linkService = linkService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Interest>>>> GetAllLinks()
        {
            return Ok(await _linkService.GetAllLinksAsync());
        }

        [HttpGet("{linkId:int}")]
        public async Task<ActionResult<ServiceResponse<Interest>>> GetLink(int linkId)
        {
            return Ok(await _linkService.GetLinkAsync(linkId));
        }

        [HttpGet("byperson/{personId:int}")]
        public async Task<ActionResult<ServiceResponse<List<Link>>>> GetLinksForPerson(int personId)
        {
            var links = await _linkService.GetASpecificPersonsLinksAsync(personId);
            return Ok(links);
        }

        
    }
}
