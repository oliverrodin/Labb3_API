namespace Labb3_API.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; }


        //Relations
        public ICollection<Person> Persons { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}
