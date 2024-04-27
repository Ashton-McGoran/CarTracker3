using System;
using System.Linq;
using CarTracker2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarTracker2.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CarTrackerContext(
                serviceProvider.GetRequiredService<DbContextOptions<CarTrackerContext>>()))
                if (!context.Car.Any())
                {
                    context.Car.AddRange(
                        new Car
                        {
                            Make = "Toyota",
                            Model = "Camry",
                            Year = 2022,
                            Color = "Red",
                            PurchaseDate = DateTime.Parse("2022-01-15"),
                            Price = 25000
                        },
                        new Car
                        {
                            Make = "Honda",
                            Model = "Civic",
                            Year = 2021,
                            Color = "Blue",
                            PurchaseDate = DateTime.Parse("2021-05-20"),
                            Price = 22000
                        }
                    
                    );
                    context.SaveChanges();
                }
        }
    }
}

