using CSharpOnlineMVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CSharpOnlineMVC.Models
{
    public static class DB
    {
        private static List<Movie> _movies { get; set; }
        public static List<Movie> Movies
        {
            get
            {
                if (_movies == null)
                {
                    _movies = new List<Movie>()
                    {
                        new Movie(1, "Return of the Jar Jar", 2000, "http://img1.wikia.nocookie.net/__cb20111208042120/starwars/images/4/42/JarJarHS-SWE.jpg", MovieRating.PG),
                        new Movie(2, "Old Yeller", 1985, "http://www.oldyelladogranch.com/puppies.jpg", MovieRating.R),
                        new Movie(3, "Game of Thrones, the Musical!", 2016, "http://i.guim.co.uk/static/w-620/h--/q-95/sys-images/Guardian/Pix/pictures/2014/6/27/1403860543867/66da8667-b19f-4eda-af46-c8adb01211d7-1020x612.jpeg", MovieRating.G)
                    };
                }
                return _movies;
            }
            set
            {
                _movies = value;
            }
        }
    }
}