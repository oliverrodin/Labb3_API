using Labb3_API.Models;

namespace Labb3_API.Services.PersonService
{
    public interface IPersonService
    {
        Task<ServiceResponse<List<Person>>> GetPersonsAsync();
    }
}
