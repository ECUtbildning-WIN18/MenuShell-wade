using System;
using System.Threading;
using MenuShell.Domain.Services;

namespace MenuShell.Views
{
    class LoginView : BaseView , ILoginView
    {
        public LoginView(string title) : base(title)
        {
            title = "";
        }

        public void Display()
        {
            Console.ResetColor();
            Console.Clear();
            Console.Write("Username:");
            var username = Console.ReadLine();
            Console.Write("Password:");
            var password = Console.ReadLine();

            Console.WriteLine("\nIs this correct? (Y)es (N)o");

            var key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.N:
                    Console.Clear();
                    Display();
                    break;
                default:
                    break;
            }
            
            var authenticationService = new AuthenticationService();

            var user = authenticationService.Authenticate(username, password);

            if (user != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n\nSuccessfully logged in!");
                Console.WriteLine($"\n\n\nRole: {user.Role}");
                Thread.Sleep(1500);
                if (user.Role == "Administrator")
                {
                    IAdministratorView administratorView = new AdministratorView("*** Administrator ***");
                    administratorView.AdminDisplay();
                }
                else
                {
                    IUserView userView =new UserView("*** User ***");
                    userView.UserDisplay();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nLogin failed. Please try again.");
                Thread.Sleep(2000);
                Display();
            }
        }
    }
}
