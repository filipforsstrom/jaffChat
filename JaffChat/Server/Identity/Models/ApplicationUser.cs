using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace JaffChat.Server.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string NickName { get; set; }
    }
}
