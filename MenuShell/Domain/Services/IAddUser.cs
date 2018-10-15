using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Domain.Services
{
    interface IAddUser
    {
        void AddNewUser(string username, string password, string role);
    }
}
