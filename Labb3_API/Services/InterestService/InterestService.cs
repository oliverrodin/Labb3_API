using System.Net.Http.Headers;
using Labb3_API.Data;
using Labb3_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb3_API.Services.InterestService
{
    public class InterestService : IInterestService
    {
        private readonly DataContext _context;

        public InterestService(DataContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse<List<Interest>>> GetAllInterestsAsync()
        {
            return new ServiceResponse<List<Interest>>()
            {
                Data = await _context.Interests.ToListAsync()
            };
        }

        public async Task<ServiceResponse<Interest>> GetInterestAsync(int interestId)
        {
            var response = new ServiceResponse<Interest>();
            var result = await _context.Interests.FirstOrDefaultAsync(i => i.Id == interestId);
            if (result == null)
            {
                response.Success = false;
                response.Message = $"An interest with id:{interestId} does not exist in this context";
            }
            else
            {
                response.Data = result;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Interest>>> GetASpecificPersonsInterestsAsync(int Id)
        {
            var response = new ServiceResponse<List<Interest>>();

            var interests = await _context.Interests
                .Where(interest => interest.Persons.Select(person => person.Id).Contains(Id))
                .ToListAsync();

            if (interests.Count == 0)
            {
                response.Success = false;
                response.Message = "Sorry, But this person does not exist in this context";
            }
            else
            {
                response.Data = interests;
            }

            return response;
        }
    }
}
