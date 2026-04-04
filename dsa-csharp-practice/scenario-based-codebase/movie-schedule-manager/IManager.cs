using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Movie_Schedule_Manager
{
    internal interface IManager
    {
        void AddMovie();

        void SearchMovie();

        void DisplayAllMovies();

        bool Authenticate(string email , string pass);
    }
}
