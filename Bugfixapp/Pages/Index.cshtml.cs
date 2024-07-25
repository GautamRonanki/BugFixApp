using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bugfixapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<DbUser> Users { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IDatabaseInitializer database)
        {
            _logger = logger;
            database.Seed().Wait();
        }

        public async Task OnGet([FromServices] IUserRepository userRepo)
        {
            var usersWithValue = userRepo.GetUsers();
            Users = await usersWithValue;
        }
    }
}
