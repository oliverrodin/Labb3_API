using Labb3_API.Models;

namespace Labb3_API.Services.PersonService
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<Person>>> GetPersonsAsync();
        Task<ServiceResponse<Person>> GetPersonAsync(int personId);

        Task<ServiceResponse<Person>> AddAInterestToAPerson(int personID, Interest interestObject);

        Task<ServiceResponse<Person>> AddNewLinksToPerson(int personID, int interestId, Link linkObject);

        
    }
}
