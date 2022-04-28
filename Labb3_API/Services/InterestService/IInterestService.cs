using Labb3_API.Models;

namespace Labb3_API.Services.InterestService
{
    public interface IInterestService
    {
        Task<ServiceResponse<List<Interest>>> GetAllInterestsAsync();
        Task<ServiceResponse<Interest>> GetInterestAsync(int interestId);
        Task<ServiceResponse<List<Interest>>> GetASpecificPersonsInterestsAsync(int Id);
    }
}
