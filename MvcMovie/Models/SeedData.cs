using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
using System;
using System.Linq;

namespace SpringFurniture.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new SpringFurnitureContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<SpringFurnitureContext>>()))
        {
            // Look for any furniture.
            if (context.Furniture.Any())
            {
                return;   // DB has been seeded
            }
            context.Furniture.AddRange(
                new Furniture
                {
                    Name = "Super Slumber",
                    Colour = "Beige",
                    Type = "Mattress",
                    Rating = "4",
                    Price = 799M
                },
                new Furniture
                {
                    Name = "Comfort Sit",
                    Colour = "Blue",
                    Type = "Recliner",
                    Rating = "4",
                    Price = 899M
                },
                new Furniture
                {
                    Name = "Family Diner",
                    Colour = "Oak",
                    Type = "Table",
                    Rating = "3",
                    Price = 999M
                },
                new Furniture
                {
                    Name = "Simply Seat",
                    Colour = "Brown",
                    Type = "Chair",
                    Rating = "5",
                    Price = 199M
                },
                new Furniture
                {
                    Name = "Hide and Sleep",
                    Colour = "Red",
                    Type = "Sofa Bed",
                    Rating = "5",
                    Price = 399M
                }
            );
            context.SaveChanges();
        }
    }
}