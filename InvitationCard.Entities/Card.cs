using System.ComponentModel.DataAnnotations;

namespace InvitationCard.Entities
{
    public class Card
    {
        [Key]
        public int ID { get; set; }
       
        public string? FirstName { get; set; }
     
        public string? LastName { get; set; }
       
        public string? MiddleName { get; set; }
      
        public string? Title { get; set; }
     
        public string? CompanyName { get; set; }
     
        public string? Slogan { get; set; }
        
        public string? Description { get; set; }
       
        public string? Address { get; set; }
     
        public string? PhoneNumber { get; set; }
      
        public string? Email { get; set; }
       
        public string? Website { get; set; }
    }
}