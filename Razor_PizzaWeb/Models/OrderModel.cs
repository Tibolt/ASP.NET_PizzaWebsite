namespace Razor_PizzaWeb.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public float BasePrize { get; set; }
        public float FinalPrize { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool SalamiPeperoni { get; set; }
        public bool Ham { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
    }
}
