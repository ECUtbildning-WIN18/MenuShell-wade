using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Domain.Services
{
    interface IUserLoader
    {
        List<User> LoadUsers();
    }
}
