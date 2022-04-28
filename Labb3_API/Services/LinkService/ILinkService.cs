using Labb3_API.Models;

namespace Labb3_API.Services.LinkService
{
    public interface ILinkService
    {
        Task<ServiceResponse<List<Link>>> GetAllLinksAsync();
        Task<ServiceResponse<Link>> GetLinkAsync(int linkId);
        Task<ServiceResponse<List<Link>>> GetASpecificPersonsLinksAsync(int personId);

        //Task<ServiceResponse<Link>> CreateNewLinkForSpecificPersonAndInterestAsync(Link newLink);
    }
}
