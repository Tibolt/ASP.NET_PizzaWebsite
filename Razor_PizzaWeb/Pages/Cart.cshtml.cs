using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor_PizzaWeb.Pages
{
    [BindProperties(SupportsGet = true)]
    public class CartModel : PageModel
    {
        public string PizzaName { get; set; }
        public float FinalPrize { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom Pizza";

        }
    }
}
