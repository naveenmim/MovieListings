using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MovieListings.Models
{
    public static class DBinitialize
    {
        public static void EnsureCreated(IServiceProvider serviceProvider)
        {
            var context = new MovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MovieContext>>());
            context.Database.EnsureCreated();
        }
    }
}