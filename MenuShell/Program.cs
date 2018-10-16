using System;
using MenuShell.Domain.Services;
using MenuShell.Views;

namespace MenuShell
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoginView startLoginView = new LoginView("*** Login ***");

            startLoginView.Display();

            Console.ReadKey();

        }
    }
}
