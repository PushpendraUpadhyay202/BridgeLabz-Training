using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Schedule_Manager
{
    internal class ManagerMain
    {
        public static List<String> movieList;
        public static List<String> movieTime;

        static ManagerMain()
        {
            movieList = new List<String>(); 
            movieTime = new List<String>();
        }
        public static void Main(string[] args)
        {
            ManagerMenu managerMain = new ManagerMenu();
            managerMain.Menu();
        }
    }
}
