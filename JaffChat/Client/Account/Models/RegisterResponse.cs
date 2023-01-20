using JaffChat.Client.Account.Contracts;

namespace JaffChat.Client.Account.Models
{
    public class RegisterResponse : IRegisterResponse
    {
        public string? Data { get; set; }
        public bool Success { get; set; }
    }
}
