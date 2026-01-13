using System;
using System.Collections.Generic;
using System.Text;

namespace Movie_Schedule_Manager
{
    internal class ManagerImpl : IManager
    {

        public void AddMovie()
        {
            Console.WriteLine("Enter the movie title : ");
            string movie = Console.ReadLine();
            Console.WriteLine("Enter the movie duration : ");
            string time = Console.ReadLine();
            ManagerMain.movieList.Add(movie);
            ManagerMain.movieTime.Add(time);
        }

        public void SearchMovie()
        {
            Console.WriteLine("Enter the Movie Name : ");
            string movie = Console.ReadLine();

            for (int i = 0; i < ManagerMain.movieList.Count; i++)
            {
                if (ManagerMain.movieList[i] == movie)
                {
                    Console.WriteLine("Movie : " + movie + " ShowTime : " + ManagerMain.movieTime[i]);
                }
            } 
            
        }

        public void DisplayAllMovies()
        {
            Console.WriteLine("Movies Are : ");
            for(int i=0; i< ManagerMain.movieList.Count; i++)
            {
                Console.WriteLine(ManagerMain.movieList[i]+"   " + ManagerMain.movieTime[i]);
            }
        }

        public bool Authenticate(string email , string pass)
        {
            if(email == Manager.emailId && pass == Manager.password)
            {
                return true;
            }
            return false; 
        }
    }
}
