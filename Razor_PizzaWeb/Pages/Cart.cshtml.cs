using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Pages
{
    [BindProperties(SupportsGet = true)]
    public class CartModel : PageModel
    {
        [BindProperty]
        public OrderModel? Order { get; set; }
        public string PizzaName { get; set; }
        public string Toppings { get; set; }
        public float FinalPrize { get; set; }

        private readonly ApplicationDbContext _context;
        public CartModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            //if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom Pizza";
            if(Request.Cookies["Order"] != null)
            {
                var order = new OrderModel();
                var cookie = Request.Cookies["Order"];
                var separator = cookie.IndexOf('&');
                var top = Request.Cookies["Toppings"];

                if (Request.Cookies["Toppings"] != null)
                    Toppings = Request.Cookies["Toppings"];
                else
                    Toppings = "...";
                PizzaName = cookie.Substring(0,separator);
                FinalPrize = float.Parse(cookie.Substring(separator+1, cookie.Length-separator-1));
            }
        }
        /*
        public IActionResult OnGetPay()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom Pizza";
            if (FinalPrize == 0) 
                return Page();

            OrderModel order = new OrderModel();
            order.PizzaName = PizzaName;
            order.FinalPrize = FinalPrize;
            order.Toppings = Toppings;

            _context.PizzaOrders.Add(order);
            _context.SaveChanges();

            retaurn RedirectToPage("/Checkout");
        }
        */
        public IActionResult OnPost()
        { 
            if (string.IsNullOrWhiteSpace(PizzaName)) PizzaName = "Custom Pizza";
            if (FinalPrize == 0) 
                return Page();
            Toppings = Request.Cookies["Toppings"];
            Order.PizzaName = PizzaName;
            Order.FinalPrize = FinalPrize;
            Order.Toppings = Toppings;

            _context.PizzaOrders.Add(Order);
            _context.SaveChanges();
            return RedirectToPage("/Checkout");
        }
    }
}
