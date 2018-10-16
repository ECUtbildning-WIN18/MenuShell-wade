using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Views
{
    class ManageView : BaseView , IManageView
    {
        public ManageView(string title) : base(title)
        {
            title = "*** Manage users ***";
        }

        public void ManageDisplay()
        {
            Console.Clear();
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. Delete user");
            Console.WriteLine("3. List users");
            Console.Write("\n\n>");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    var addUser = new AddView("*** Add User ***");
                    addUser.AddDisplay();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    var removeUser = new RemoveView("*** Remove User ***");
                    removeUser.RemoveDisplay();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    // underprogress List users
                    break;

                default:
                    Console.WriteLine("The options are 1 or 2 .");
                    ManageDisplay();
                    break;
            }
        }
        
    }
}
