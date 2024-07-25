using Bugfixapp;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class DatabaseInitializerTests
    {
        [Fact]
        public async Task TestSeedOnlyRunsOnce()
        {
            using var db = new AppDbContext(new DbContextOptionsBuilder<AppDbContext>().UseInMemoryDatabase("testdbinit").Options);
            Assert.Empty(db.Values);
            var init = new DatabaseInitializer(db);
            await init.Seed();
            await init.Seed();
            Assert.Equal(2, await db.Values.CountAsync());
        }
    }
}
