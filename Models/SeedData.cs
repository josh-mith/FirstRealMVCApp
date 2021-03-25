using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace Assignment3.Models
{ 
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            MovieDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<MovieDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new MovieResponse
                    {
                        Category = "Mystery",
                        Title = "The Prestige",
                        Year = 2006,
                        Director = "Christopher Nolan",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "Awesome movie."
                    },
                    new MovieResponse
                    {
                        Category = "Action",
                        Title = "Inception",
                        Year = 2010,
                        Director = "Christopher Nolan",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "Another great movie by Nolan."
                    },
                    new MovieResponse
                    {
                        Category = "Sci-fi",
                        Title = "Guardians of the Galaxy",
                        Year = 2014,
                        Director = "James Gunn",
                        Rating = "PG-13",
                        Edited = false,
                        LentTo = "",
                        Notes = "I am Groot."
                    });
            }
        }
    }
}
