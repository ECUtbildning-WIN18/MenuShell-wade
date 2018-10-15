using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Domain
{
    class User
    {
        public string Username { get; }
        public string Password { get; }
        public string Role { get; }

        public User(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }
    }
}
