using System;

namespace MenuShell.Views
{
    abstract class BaseView
    {
        public string Title { get; }

        protected BaseView(string title)
        {
            Title = title;
            Console.Title = title;
        }
    }
}
