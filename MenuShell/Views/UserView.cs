using System;
using System.Collections.Generic;
using System.Text;

namespace MenuShell.Views
{
    class UserView : BaseView,IUserView
    {
        public UserView(string title) : base(title)
        {
        }

        public void UserDisplay()
        {
            Console.WriteLine("Welcome to our System !");
        }
    }
}
