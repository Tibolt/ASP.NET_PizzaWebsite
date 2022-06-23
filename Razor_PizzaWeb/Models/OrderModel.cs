using System.ComponentModel.DataAnnotations;

namespace Razor_PizzaWeb.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string? PizzaName { get; set; }
        public float BasePrize { get; set; }
        public float FinalPrize { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool SalamiPeperoni { get; set; }
        public bool Ham { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        [RegularExpression(@"^\\?([0-9]{3})\)?[- ]?([0-9]{3})?[- ]?([0-9]{3})$", ErrorMessage = "The PhoneNumber field is not a valid phone number")]
        public string? Number { get; set; }
    }
}
