using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Api_ExampleASP.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace api_exampleASP.Pages_User
{
    public class LoginModel : PageModel
    {
        [Parameter]
        public string? Message { get; set; }

        private readonly Api_ExampleASP.Models.PeopleContext _context;

        public LoginModel(Api_ExampleASP.Models.PeopleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public bool DisplayAlert { get; set; }

        [BindProperty]
        public new User User { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            User.CreationDate = DateTime.Now;

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == User.Username && u.Passwrd == User.Passwrd);
            if (user != null)
            {
                Message = "Successful Login. Hi " + user.Username;
            }
            else
            {
                Message = "Failed to Login. Try again.";
            }
            
            await Task.Delay(5000);

            // await js.InvokeVoidAsync("ShowModal");
            
            return RedirectToPage("./Index");
        }

    }
}