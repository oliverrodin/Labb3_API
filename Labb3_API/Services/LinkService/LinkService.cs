using Labb3_API.Data;
using Labb3_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3_API.Services.LinkService
{
    public class LinkService : ILinkService
    {
        private readonly DataContext _context;

        public LinkService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Link>>> GetAllLinksAsync()
        {
            return new ServiceResponse<List<Link>>()
            {
                Data = await _context.Links.ToListAsync()
            };
        }

        public async Task<ServiceResponse<Link>> GetLinkAsync(int linkId)
        {
            var response = new ServiceResponse<Link>();
            var result = await _context.Links.FirstOrDefaultAsync(i => i.Id == linkId);
            if (result == null)
            {
                response.Success = false;
                response.Message = $"An interest with id:{linkId} does not exist in this context";
            }
            else
            {
                response.Data = result;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Link>>> GetASpecificPersonsLinksAsync(int personId)
        {
            var response = new ServiceResponse<List<Link>>();
            var success = await _context.Persons
                .AnyAsync(person => person.Id == personId );

            if (success)
            {
                response.Data = await _context.Links
                    .Where(link => link.Person.Id == personId)
                    .ToListAsync();
            }
            else
            {
                response.Success = false;
                response.Message = "Sorry, but this person does not exist in this context.";
            }
            return response;
        }

    //    public async Task<ServiceResponse<Link>> CreateNewLinkForSpecificPersonAndInterestAsync(Link newLink)
    //    {
    //        var response = new ServiceResponse<Link>();
    //        var createLink = newLink;

    //        _context.Links.Add(createLink);
    //        await _context.SaveChangesAsync();

    //        var link = await _context.Links
    //            .FirstOrDefaultAsync(l => l.Url == newLink.Url);

    //        response.Data = link;

    //        return response;
    //    }
    }
}
