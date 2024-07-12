using MoodRadio.DB;
using MoodRadio.Models;

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
                // Add initial data
                context.Users.AddRange(
                    new User
                    {
                        UserName = "@WestiferRobin",
                        FirstName = "Wes",
                        LastName = "Webb",
                        Email = "w.webb0919@gmail.com",
                        BirthDate = new DateTimeOffset(1993, 3, 12, 0, 0, 0, TimeSpan.Zero),
                    }
                    // Add more entities as needed
                );
                context.SaveChanges(); // Save changes to the database
            }
        }
    }
}

