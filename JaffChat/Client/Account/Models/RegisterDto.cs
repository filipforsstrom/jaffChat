using System.ComponentModel.DataAnnotations;

namespace JaffChat.Client.Account.Models
{
    public class RegisterDto
    {
        public string Email { get; set; }

        public string Username { get; set; }

        
        public string Password { get; set; }

        
    }
}
