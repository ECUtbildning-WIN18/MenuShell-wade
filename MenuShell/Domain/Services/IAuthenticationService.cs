using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Domain.Services
{
    interface IAuthenticationService
    {
        User Authenticate(string username, string password);
    }
}
