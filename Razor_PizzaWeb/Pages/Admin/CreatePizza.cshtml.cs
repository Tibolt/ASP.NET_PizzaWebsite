using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Pages.Admin
{
    public class CreatePizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel? Pizza { get; set; }

        private readonly ApplicationDbContext _context;
        public CreatePizzaModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            if (Pizza == null)
            {
                return Page();
            }

            PizzaModel model = new PizzaModel();
            model = Pizza;
            model.FinalPrize = model.BasePrize;

            if (model.TomatoSauce) model.FinalPrize += 1;
            if (model.Cheese) model.FinalPrize += 1;
            if (model.SalamiPeperoni) model.FinalPrize += 2;
            if (model.Ham) model.FinalPrize += 2;
            if (model.Mushroom) model.FinalPrize += 1;
            if (model.Tuna) model.FinalPrize += 2;

            _context.PizzaModels.Add(model);
            _context.SaveChanges();


            return RedirectToPage("/Index", new {Pizza.PizzaName, Pizza.FinalPrize});
            //return RedirectToPage("/Index");
        }
    }
}
