using System.Reflection.Metadata;

namespace Labb3_API.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        //Realtions 

        public Interest Interest { get; set; }
        public int InterestId { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }

    }
}
