using AbstractFactoryRestaurant.Interfaces;
using AbstractFactoryRestaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConcreteFactories
{
    public class BulgarianRestaurant : IRestaurantFactory
    {
        public ISalad OrderSalad(int preparationTime)
        {
            return new ShopskaSalad(preparationTime);
        }

        public IPizza OrderPizza(int preparationTime)
        {
            return new VegetarianPizza(preparationTime);
        }

        public IDessert OrderDessert(int preparationTime)
        {
            return new CaramelCustard(preparationTime);
        }
    }
}