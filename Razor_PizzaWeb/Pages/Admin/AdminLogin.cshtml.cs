using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;
using System.Data.SqlClient;
using System.Security.Claims;

namespace Razor_PizzaWeb.Pages.Admin
{
    public class AdminLoginModel : PageModel
    {  
        [BindProperty]
        public AdminModel? Admin { get; set; }

        private readonly ApplicationDbContext _context;

        public AdminLoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync(AdminModel admin)
        {
            try
            {
                var user = _context.AdminModels.Single(u => u.Login == admin.Login && u.Password == admin.Password);
                if(user != null)
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Login),
                        new Claim(ClaimTypes.Role, "Admin"),
                    };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = false,
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);


                    return RedirectToPage("/Index");
                }
            }
            catch (Exception ex)
            {

            }
            return this.Redirect("/Admin/AdminLogin");
        }
    }
}
