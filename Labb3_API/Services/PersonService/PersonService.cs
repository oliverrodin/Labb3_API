using Labb3_API.Data;
using Labb3_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3_API.Services.PersonService
{
    public class PersonService : IPersonService
    {
        private readonly DataContext _context;

        public PersonService(DataContext context)
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<Person>>> GetPersonsAsync()
        {
            return new ServiceResponse<List<Person>>
            {
                Data = await _context.Persons.ToListAsync()
            };
        }

        public async Task<ServiceResponse<Person>> GetPersonAsync(int personId)
        {
            var response = new ServiceResponse<Person>();
            var result = await _context.Persons.FirstOrDefaultAsync(i => i.Id == personId);
            if (result == null)
            {
                response.Success = false;
                response.Message = $"An interest with id:{personId} does not exist in this context";
            }
            else
            {
                response.Data = result;
            }

            return response;
        }

        public async Task<ServiceResponse<Person>> AddAInterestToAPerson(int personID, Interest interestObject)
        {
            var response = new ServiceResponse<Person>();
            var personToUpdate = await _context.Persons
                .Include(p => p.Interests)
                .FirstOrDefaultAsync(p => p.Id == personID);

            if (personToUpdate == null)
            {
                response.Success = false;
                response.Message = "Sorry, but this person does not exist in this context.";
                return response;
            }
            else
            {
                Interest? newInterest;
                var interest = _context.Interests.Any(i => i.Id == interestObject.Id);
                if (interest)
                {
                    newInterest = await _context.Interests.FirstOrDefaultAsync(i => i.Id == interestObject.Id);

                }
                else
                {
                    newInterest = new Interest()
                    {
                        Title = interestObject.Title,
                        Description = interestObject.Description
                    };

                    await _context.Interests.AddAsync(newInterest);
                    await _context.SaveChangesAsync();
                }

                personToUpdate.Interests.Add(newInterest);

                await _context.SaveChangesAsync();

                response.Data = await _context.Persons
                        .Include(p => p.Interests)
                        .FirstOrDefaultAsync(p => p.Id == personID);

                return response;
            }
                
        }

        public async Task<ServiceResponse<Person>> AddNewLinksToPerson(int personID, int interestId, Link linkObject)
        {
            var response = new ServiceResponse<Person>();

            var person = await _context.Persons
                .Include(l => l.Links)
                .FirstOrDefaultAsync(
                p => p.Id == personID);

            var interest = await _context.Interests
                .Include(l => l.Links)
                .FirstOrDefaultAsync(i => i.Id == interestId);
            
            if (person == null)
            {
                response.Success = false;
                response.Message = $"A person with the given id: {personID} does not exist in this context.";
            }
            else
            {
                person.Links.Add(linkObject);
            }

            if (interest == null)
            {
                response.Success = false;
                response.Message = $"A interest with the given id: {interestId} does not exist in this context.";
            }
            else
            {
                interest.Links.Add(linkObject);
            }

            if (response.Success)
            {
                await _context.SaveChangesAsync();

                response.Data = await _context.Persons
                    .Include(l => l.Links)
                    .Include(i => i.Interests)
                    .FirstOrDefaultAsync(p => p.Id == personID);

                return response;
            }
            else
            {
                return response;
            }
            
        }
    }


}
