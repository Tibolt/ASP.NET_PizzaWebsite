using System.ComponentModel.DataAnnotations;

namespace Razor_PizzaWeb.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string? PizzaName { get; set; }
        public float BasePrize { get; set; }
        public float FinalPrize { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        [RegularExpression(@"^\\?([0-9]{3})\)?[- ]?([0-9]{3})?[- ]?([0-9]{3})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string? Number { get; set; }
        public string? Toppings { get; set; }
    }
}
