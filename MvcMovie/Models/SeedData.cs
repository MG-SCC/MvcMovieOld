using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Romeo + Juliet",
                    ReleaseDate = DateTime.Parse("1996-11-01"),
                    Genre = "Romantic Drama",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Clerks ",
                    ReleaseDate = DateTime.Parse("1994-10-09"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Buffalo ’66’",
                    ReleaseDate = DateTime.Parse("1998-6-10"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Men in Black",
                    ReleaseDate = DateTime.Parse("1997-7-02"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "The Ice Storm",
                    ReleaseDate = DateTime.Parse("1997-9-27"),
                    Genre = "Drama",
                    Rating = "PG-13",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}