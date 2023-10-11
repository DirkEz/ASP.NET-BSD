using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace geoprofs.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public InputModel Input { get; set; }
        public UserModel LoggedIn { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
            
        }

        public void OnGet()
        {
            // Handle GET request (if needed)LoggedIn
            LoggedIn = true;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            // Validate the user's credentials (replace this with your actual authentication logic)
            if (Input.Email == "user@example.com" && Input.Password == "password")
            {
                // Authentication successful
                // You can add authentication logic here, such as setting claims, cookies, etc.
              
                // For example, you can redirect to a specific page after successful login
                return RedirectToPage("/User");
            }

            // Authentication failed, show error message
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

        public static implicit operator LoginModel(bool v)
        {
            throw new NotImplementedException();
        }
    }
}
