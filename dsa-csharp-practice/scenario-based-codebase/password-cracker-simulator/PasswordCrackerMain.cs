using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Password_Cracker_Simulator
{
    internal class PasswordCrackerMain
    {
        public static void Main(string[] args)
        {
            PasswordCrackerMenu menu = new PasswordCrackerMenu();
            menu.Menu();
        }
    }
}
