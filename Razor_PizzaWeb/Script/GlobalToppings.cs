using Razor_PizzaWeb.Data;
using Razor_PizzaWeb.Models;

namespace Razor_PizzaWeb.Script
{
    public class GlobalToppings
    {
        public static String GetToppings(PizzaModel pizzaList)
        {
            var toppings = "";

            if (pizzaList.TomatoSauce)
                toppings += "Tomato Sauce, ";
            if (pizzaList.Cheese)
                toppings += "Cheese, ";
            if (pizzaList.Ham)
                toppings += "Ham, ";
            if (pizzaList.SalamiPeperoni)
                toppings += "Peperoni, ";
            if (pizzaList.Mushroom)
                toppings += "Mushroom, ";
            if (pizzaList.Tuna)
                toppings += "Tuna, ";
            toppings = toppings.TrimEnd(',', ' ');
            return toppings;
        }

    }
}
