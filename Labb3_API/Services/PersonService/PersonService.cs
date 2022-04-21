using Labb3_API.Models;

namespace Labb3_API.Services.PersonService
{
    public class PersonService : IPersonService
    {
        public Task<ServiceResponse<List<Person>>> GetPersonsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
