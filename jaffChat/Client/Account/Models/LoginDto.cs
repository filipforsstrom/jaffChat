using System.ComponentModel.DataAnnotations;

namespace JaffChat.Client.Account.Models
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
