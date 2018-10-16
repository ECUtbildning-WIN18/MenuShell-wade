using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Views
{
    class AdministratorView : BaseView,IAdministratorView
    {
        public AdministratorView(string title) : base(title)
        {
            title = "*** Administrator ***";
        }

        public void AdminDisplay()
        {
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("1. Manage users");
            Console.WriteLine("2. Exit");
            Console.Write("\n\n>");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    IManageView manage = new ManageView("*** Manage users ***");
                    manage.ManageDisplay();

                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;

                default:
                    Console.WriteLine("The options are 1 or 2 .");
                    AdminDisplay();
                    break;
            }

        }
    }
}
