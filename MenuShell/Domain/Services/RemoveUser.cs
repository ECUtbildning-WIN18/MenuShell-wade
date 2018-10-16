using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using MenuShell.Views;

namespace MenuShell.Domain.Services
{
    class RemoveUser
    {
        private readonly IUserLoader _userLoader;
        public RemoveUser()
        {
            _userLoader = new UserLoader();
        }

        public void Remove (string username, string password, string role)
        {
            var users = _userLoader.LoadUsers();

            var doc = XDocument.Load("Users.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                if (element.Attribute("username").Value == username && element.Attribute("password").Value==password&& element.Attribute("role").Value==role)
                {
                    element.Remove();
                }
                
            }
            doc.Save("Users.xml");

            var login = new LoginView("*** Login ***");
            login.Display();
        }

    }
}
