using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BoardNet.Data;
using System;
using System.Linq;

namespace BoardNet.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BoardNetContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BoardNetContext>>()))
            {
                // Look for any movies.
                if (context.User.Any())
                {
                    return;   // DB has been seeded
                }
                context.User.AddRange(
                    new User
                    {
                        Name = "kim",
                        Date = DateTime.Parse("1989-2-12"),
                        Gender = "M",
                        Age = 35
                    },
                    new User
                    {
                        Name = "lee",
                        Date = DateTime.Parse("1989-2-12"),
                        Gender = "W",
                        Age = 35
                    },
                    new User
                    {
                        Name = "park",
                        Date = DateTime.Parse("1988-2-12"),
                        Gender = "M",
                        Age = 36
                    },
                    new User
                    {
                        Name = "choi",
                        Date = DateTime.Parse("1990-2-12"),
                        Gender = "W",
                        Age = 34
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
