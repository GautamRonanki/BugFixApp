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

		DbValue value1 = new DbValue { Title = "Value 1" };
		DbValue value2 = new DbValue { Title = "Value 2" };
		DbUser user1 = new DbUser { Name = "User 1" };
		DbUser user2 = new DbUser { Name = "User 2" };
		// Add some test data to the database
		// TODO: don't do anything if there are already values in the database
		public async Task Seed()
		{
			context.Values.Add(value1);
			context.Values.Add(value2);

			context.Users.Add(user1);
			context.Users.Add(user2);

			context.UserValues.Add(new DbUserValue { User = user1, Value = value1 });
			context.UserValues.Add(new DbUserValue { User = user1, Value = value2 });
			context.UserValues.Add(new DbUserValue { User = user2, Value = value2 });

			await context.SaveChangesAsync();
		}
	}
}
