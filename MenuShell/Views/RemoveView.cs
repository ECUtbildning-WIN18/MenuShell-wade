using System;
using System.Collections.Generic;
using System.Text;
using MenuShell.Domain.Services;

namespace MenuShell.Views
{
    class RemoveView : BaseView
    {
        public RemoveView(string title) : base(title)
        {
            title = "*** Remove User ***";
        }

        public void RemoveDisplay()
        {
            Console.Clear();
            Console.WriteLine("# Delete User");

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
                    RemoveDisplay();
                    break;
                default:
                    break;
            }
            var user = new RemoveUser();
            user.Remove(username, password, role);
        }
    }
}
