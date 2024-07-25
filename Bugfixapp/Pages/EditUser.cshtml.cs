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
    public class EditUserModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public DbUser DbUser { get; set; }
        public List<DbValue> Values { get; set; }

        public EditUserModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet([FromServices] IUserRepository userRepo, Guid userId)
        {
            DbUser = await userRepo.GetUser(userId); // Added await
            Values = await userRepo.GetValues(); // Added await
        }

        public async Task<IActionResult> OnPost([FromServices] IUserRepository userRepo, Guid userId, List<Guid> values)
        {
            await userRepo.UpdateUserValues(userId, values);
            return RedirectToPage("Index");
        }
    }
}
