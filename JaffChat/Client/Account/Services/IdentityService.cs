using JaffChat.Client.Account.Contracts;
using JaffChat.Client.Account.Models;
using System.Net.Http.Json;

namespace JaffChat.Client.Account.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly HttpClient _httpClient;

        public IdentityService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<RegisterResponse> Register(RegisterForm register)
        {
            RegisterResponse registerResponse = new();

            RegisterDto registerRequest = new RegisterDto()
            {
                Email = register.Email,
                Password = register.Password,
                Username = register.Username,
            };

            var response = await _httpClient.PostAsJsonAsync("api/Identity/Register", registerRequest);

            if(!response.IsSuccessStatusCode)
            {
                registerResponse.Data = await response.Content.ReadAsStringAsync();
                return registerResponse;
            }

            registerResponse.Success = true;
            return registerResponse;

        }
        public async Task<RegisterResponse> Login(LoginDto loginDto)
        {
            RegisterResponse registerResponse= new();

            var response = await _httpClient.PostAsJsonAsync("api/Identity/Login", loginDto);

            if (!response.IsSuccessStatusCode)
            {
                registerResponse.Data = await response.Content.ReadAsStringAsync();
                return registerResponse;
            }
            registerResponse.Success = true;
            return registerResponse;
            
        }

    }
}
