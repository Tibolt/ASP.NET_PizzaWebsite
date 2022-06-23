using Microsoft.AspNetCore.Identity;

namespace Razor_PizzaWeb.Models
{
    public class AdminModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
