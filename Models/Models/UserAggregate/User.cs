using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models.UserAggregate
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }   
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public int AccountType { get; set; }
        [NotMapped]
        public string Token { get; set; }  
        
    }
}
