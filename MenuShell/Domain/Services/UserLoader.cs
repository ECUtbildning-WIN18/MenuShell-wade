using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace MenuShell.Domain.Services
{
    class UserLoader : IUserLoader
    {
        public List<User> LoadUsers()
        {
            var users = new List<User>();

            var doc = XDocument.Load("Users.xml");

            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                var role = element.Attribute("role").Value;


                users.Add(new User(username, password, role));
            }

            return users;
        }

      /*public Dictionary<string, User> LoadUsers()
        {
            var users = new Dictionary<string,User>();
            var doc = XDocument.Load("Users.xml");
            var root = doc.Root;

            foreach (var element in root.Elements())
            {
                var username = element.Attribute("username").Value;
                var password = element.Attribute("password").Value;
                string role = element.Attribute("role").Value;

                users.Add(role, new User(username, password, role));
            }

            return users;
        }*/
        
    }
}
