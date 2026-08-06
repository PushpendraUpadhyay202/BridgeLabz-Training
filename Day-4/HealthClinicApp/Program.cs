using System;
using HealthClinicApp.Menu;

namespace HealthClinicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            menu.DisplayMainMenu();
        }
    }
}