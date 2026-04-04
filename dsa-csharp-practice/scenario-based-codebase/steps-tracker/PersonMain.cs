using System;
using System.Collections.Generic;
using System.Text;

namespace Steps_Tracker
{
    internal class PersonMain
    {
        public static void Main(string[] args)
        {
            PersonMenu menu = new PersonMenu();
            menu.ShowMenu();
        }
    }
}
