using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using MenuShell.Views;

namespace MenuShell.Domain.Services
{
    class AddUser : IAddUser
    {
        private readonly IUserLoader _userLoader;

        public AddUser()
        {
            _userLoader = new UserLoader();
        }
        public void AddNewUser(string username,string password , string role)
        {
            var users = _userLoader.LoadUsers();

            users.Add(new User(username,password,role));

            var doc = XDocument.Load("Users.xml");

            XElement root = new XElement("User");

            root.Add(new XAttribute("username", username));
            root.Add(new XAttribute("password", password));
            root.Add(new XAttribute("role", role));
            doc.Element("Users").Add(root);
            doc.Save("Users.xml");

            var login = new LoginView("*** Login ***");
            login.Display();
        }
    }
  
}
