using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel? Pizza {get; set;}
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }

            Pizza.FinalPrize = Pizza.BasePrize;

            if (Pizza.TomatoSauce) Pizza.FinalPrize += 1;
            if (Pizza.Cheese) Pizza.FinalPrize += 1;
            if (Pizza.SalamiPeperoni) Pizza.FinalPrize += 2;
            if (Pizza.Ham) Pizza.FinalPrize += 2;
            if (Pizza.Mushroom) Pizza.FinalPrize += 1;
            if (Pizza.Tuna) Pizza.FinalPrize += 2;

            return RedirectToPage("/Cart", new {Pizza.PizzaName, Pizza.FinalPrize});
        }
    }
}
