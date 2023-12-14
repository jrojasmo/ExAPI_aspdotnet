using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Api_ExampleASP.Models;

namespace api_exampleASP.Pages_User
{
    public class DetailsModel : PageModel
    {
        private readonly Api_ExampleASP.Models.PeopleContext _context;

        public DetailsModel(Api_ExampleASP.Models.PeopleContext context)
        {
            _context = context;
        }

        public new User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
