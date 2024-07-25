using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bugfixapp
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public Task<DbUser> GetUser(Guid userId)
        {
            return context.Users
                .Include(u => u.UserValues)
                .ThenInclude(uv => uv.Value) // Ensuring the Value is included
                .FirstAsync(u => u.UserId == userId);
        }

        public async Task<List<DbUser>> GetUsers()
        {
            return await context.Users
                .Include(u => u.UserValues)
                .ThenInclude(uv => uv.Value) // Ensuring the Value is included
                .ToListAsync();
        }

        public Task<List<DbValue>> GetValues()
        {
            return context.Values.ToListAsync();
        }

        public async Task UpdateUserValues(Guid userId, List<Guid> values)
        {
            context.UserValues.RemoveRange(context.UserValues.Where(uv => uv.UserId == userId));
            foreach (var value in values)
            {
                context.UserValues.Add(new DbUserValue { UserId = userId, ValueId = value });
            }
            await context.SaveChangesAsync();
        }
    }
}
