using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace Labb3_API.Models
{
    public class Link
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;

        //Realtions 



        public int? InterestId { get; set; }

        [ForeignKey("InterestId")] 
        [JsonIgnore]
        public Interest? Interest { get; set; }
        


        public int? PersonId { get; set; }
        
        [ForeignKey("PersonId")]
        [JsonIgnore]
        public Person? Person { get; set; }
       

    }
}
