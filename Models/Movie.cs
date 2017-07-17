using System;

namespace MovieListings.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public String MovieName { get; set; }
        public DateTime ReleaseDate { get; set; }   
        public string Genre { get; set; }
        public int Rating { get; set; }
    }

}