using System.ComponentModel.DataAnnotations;

namespace JaffChat.Client.Models.Account
{
    public class AddUser
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "The Password field must be a minimum of 6 characters")]
        public string Password { get; set; }
    }
}
