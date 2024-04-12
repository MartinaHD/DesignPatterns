using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimpleFactory
{
    public class DishFactory
    {
        public static Dish GetDish(DishType dishType, int preparationTime)
        {
            switch (dishType)
            {
                case DishType.ShopskaSalad:
                case DishType.CaesarSalad:
                    return new Salad(preparationTime);
                case DishType.Pepperoni:
                case DishType.Vegetarian:
                    return new Pizza(preparationTime);
                case DishType.ChocolateCake:
                case DishType.CaramelCustard:
                    return new Dessert(preparationTime);
                default:
                    throw new ArgumentException("Invalid dish type");
            }
        }
    }
}
