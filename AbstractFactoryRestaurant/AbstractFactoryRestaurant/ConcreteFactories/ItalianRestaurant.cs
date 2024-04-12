using AbstractFactoryRestaurant.Interfaces;
using AbstractFactoryRestaurant.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.ConcreteFactories
{
    public class ItalianRestaurant : IRestaurantFactory
    {
        public ISalad OrderSalad(int preparationTime)
        {
            return new CaesarSalad(preparationTime);
        }

        public IPizza OrderPizza(int preparationTime)
        {
            return new PepperoniPizza(preparationTime);
        }

        public IDessert OrderDessert(int preparationTime)
        {
            return new ChocolateCake(preparationTime);
        }
    }
}