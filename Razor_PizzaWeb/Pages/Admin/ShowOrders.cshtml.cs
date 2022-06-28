using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class ShowOrdersModel : PageModel
    {
        public string OrderNo { get; set; }
        public string CustomerId { get; set; }
        public string PizzaName { get; set; }
        public float Prize { get; set; }
        public List<OrderModel> OrderList = new List<OrderModel>();
        public Dictionary<int, String> ToppingsList = new Dictionary<int, String>();

        private readonly ApplicationDbContext _context;

        public ShowOrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            OrderList = _context.PizzaOrders.ToList();
        }
        
        public IActionResult OnGetDelete(int? id)
        {
            try
            {
                var obj = _context.PizzaOrders.Find(id);
                if (obj == null)
                    return NotFound();
                _context.PizzaOrders.Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

            }
            return RedirectToPage("/Admin/ShowOrders");
        }

    }
}
