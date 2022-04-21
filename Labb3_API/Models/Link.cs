using System.Reflection.Metadata;

namespace Labb3_API.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        //Realtions 
        public ICollection<Person> Persons { get; set; }
        public ICollection<Interest> Interests { get; set; }
    }
}
