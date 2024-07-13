using MoodRadio.Utils;

namespace MoodRadio.DB
{
    public static class DbInitializer
    {
        public static void Initialize(PostgresContext context)
        {
            context.Database.EnsureCreated(); // Ensure the database is created

            // Check if the table is empty
            if (!context.Users.Any() && Constants.IsTest)
            {
                DbTestData.InitTestData(context);
            }
        }
    }
}

