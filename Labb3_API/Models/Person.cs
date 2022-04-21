namespace Labb3_API.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        //Relations
        public ICollection<Interest> Interests { get; set; }
        public ICollection<Link> Links { get; set; }

    }
}
