using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Pages
{
    [BindProperties(SupportsGet = true)]
    public class CartModel : PageModel
    {
        public string PizzaName { get; set; }
        public float FinalPrize { get; set; }

        private readonly ApplicationDbContext _context;
        public CartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom Pizza";
        }
        public IActionResult OnGetPay()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom Pizza";

            OrderModel order = new OrderModel();
            order.PizzaName = PizzaName;
            order.FinalPrize = FinalPrize;

            _context.PizzaOrders.Add(order);
            _context.SaveChanges();

            return RedirectToPage("/Checkout");
        }
    }
}
