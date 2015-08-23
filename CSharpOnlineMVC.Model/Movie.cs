using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnlineMVC.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public int YearReleased { get; set; }
        public string ImageUrl { get; set; }
        public MovieRating Rating { get; set; }

        public Movie()
        {
        }

        public Movie(int id, string title, int year, string image, MovieRating rating)
        {
            this.MovieId = id;
            this.Title = title;
            this.YearReleased = year;
            this.ImageUrl = image;
            this.Rating = rating;
        }
    }

    public enum MovieRating
    {
        G,
        PG,
        PG13,
        R
    }
}