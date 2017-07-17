using Microsoft.EntityFrameworkCore;

namespace MovieListings.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {}

        public DbSet<MovieListings.Models.Movie> Movie {get;set;}
    }
}