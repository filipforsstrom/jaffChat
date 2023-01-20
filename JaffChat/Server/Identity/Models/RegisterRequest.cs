﻿using System.ComponentModel.DataAnnotations;

namespace JaffChat.Server.Identity.Models
{
    public class RegisterRequest
    {
        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }
}
