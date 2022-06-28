using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Net.Http.Headers;
using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Http;
using Razor_PizzaWeb.Script;

namespace Razor_PizzaWeb.Pages
{
    public class PizzaListModel : PageModel
    {
        public List<PizzaModel> PizzaList = new List<PizzaModel>();

        private readonly ApplicationDbContext _context;
        public PizzaListModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public void OnGet()
        {
            PizzaList = _context.PizzaModels.ToList(); 
        }

        public IActionResult OnGetOrder(int id)
        {
            var name = _context.PizzaModels.Find(id).PizzaName;
            var prize = _context.PizzaModels.Find(id).FinalPrize;

            String toppings = GlobalToppings.GetToppings(_context.PizzaModels.Find(id));

            string value = name + "&" + prize.ToString();
            Response.Cookies.Append("Order", value);
            Response.Cookies.Append("Toppings", toppings);


            return RedirectToPage("/Cart", new { PizzaName = name, FinalPrize = prize });
        }
    }
}
