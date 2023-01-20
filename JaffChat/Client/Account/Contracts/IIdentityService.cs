using JaffChat.Client.Account.Models;

namespace JaffChat.Client.Account.Contracts
{
    public interface IIdentityService
    {
        Task<RegisterResponse> Register(RegisterForm register);

    }
}
