using System;
using System.Collections.Generic;
using System.Text;
using MenuShell.Domain.Services;

namespace MenuShell.Views
{
    class AddView :BaseView
    {
        public AddView(string title) : base(title)
        {
            title = "*** Add User ***";
        }

        public void AddDisplay()
        {
            Console.Clear();
            Console.WriteLine("# Add user");

            Console.Write("\nUsername:");
            string username = Console.ReadLine();
            Console.Write("Password:");
            string password = Console.ReadLine();
            Console.Write("Role:");
            string role = Console.ReadLine();

            Console.WriteLine("\nIs this correct? (Y)es (N)o");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.N:
                    Console.Clear();
                    AddDisplay();
                    break;
                default:
                    break;
            }


            var user = new AddUser();
            user.AddNewUser(username,password,role);
        }
    }
}
