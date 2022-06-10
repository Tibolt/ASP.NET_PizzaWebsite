using System.ComponentModel;

namespace Razor_PizzaWeb.Models
{
    public class PizzaModel
    {
        [DisplayName("Pizza Name")]
        public string? PizzaName { get; set; }
        public float BasePrize { get; set; } = 10;
        [DisplayName("Prize")]
        public float FinalPrize { get; set; } = 0;
        [DisplayName("Tomato Sauce ")]
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        [DisplayName("Salami Peperoni")]
        public bool SalamiPeperoni { get; set; }
        public bool Ham { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
    }
}