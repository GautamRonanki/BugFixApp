using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bugfixapp
{
    public class DatabaseInitializer : IDatabaseInitializer
    {
        private readonly AppDbContext context;

        public DatabaseInitializer(AppDbContext context)
        {
            this.context = context;
        }

        DbValue value1 = new DbValue { ValueId = Guid.NewGuid(), Title = "Value 1" }; // Added ValueId initialization
        DbValue value2 = new DbValue { ValueId = Guid.NewGuid(), Title = "Value 2" }; // Added ValueId initialization
        DbUser user1 = new DbUser { UserId = Guid.NewGuid(), Name = "User 1" }; // Added UserId initialization
        DbUser user2 = new DbUser { UserId = Guid.NewGuid(), Name = "User 2" }; // Added UserId initialization

        // Add some test data to the database
        // TODO: don't do anything if there are already values in the database
        public async Task Seed()
        {
            // Checking if any values already exist
            if (!context.Values.Any())
            {
                context.Values.Add(value1); // Add values only if they don't exist
                context.Values.Add(value2);
            }

            // Checking if any users already exist
            if (!context.Users.Any())
            {
                context.Users.Add(user1); // Add users only if they don't exist
                context.Users.Add(user2);
            }

            // Checking if any user-values already exist
            if (!context.UserValues.Any())
            {
                context.UserValues.Add(new DbUserValue { User = user1, Value = value1 }); // Add user-values only if they don't exist
                context.UserValues.Add(new DbUserValue { User = user1, Value = value2 });
                context.UserValues.Add(new DbUserValue { User = user2, Value = value2 });
            }

            await context.SaveChangesAsync();
        }
    }
}
