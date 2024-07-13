using Microsoft.EntityFrameworkCore;
using MoodRadio.DB;
using MoodRadio.Models.UserModels;

namespace MoodRadio
{
    public static class DbInitializer
    {
        public static void Initialize(PostgresContext context)
        {
            context.Database.EnsureCreated(); // Ensure the database is created

            // Check if the table is empty
            if (!context.Users.Any())
            {
                var testUsers = new User[]
                {
                    new()
                    {
                        Id = new Guid("00000000-0000-0000-0000-000000000000"),
                        UserName = "@WestiferRobin",
                        FirstName = "Wes",
                        LastName = "Webb",
                        Email = "w.webb0919@gmail.com",
                        BirthDate = new DateTimeOffset(1993, 3, 12, 0, 0, 0, TimeSpan.Zero),
                    },
                    new()
                    {
                        Id = Guid.NewGuid(),
                        UserName = "@AI_Alchemist",
                        FirstName = "Jon",
                        LastName = "Rendar",
                        Email = "the.ai.alchemist369@gmail.com",
                        BirthDate = new DateTimeOffset(1994, 8, 24, 0, 0, 0, TimeSpan.Zero),
                    }
                };

                // Add initial data
                context.Users.AddRange(testUsers);
                context.SaveChanges(); // Save changes to the database
            }
        }
    }
}

