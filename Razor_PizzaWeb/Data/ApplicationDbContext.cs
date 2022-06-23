using Microsoft.EntityFrameworkCore;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<OrderModel> PizzaOrders { get; set; }
        public DbSet<PizzaModel> PizzaModels { get; set; }
        public DbSet<AdminModel> AdminModels { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }
    }
}
