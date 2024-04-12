using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Restaurant
{
    public class Client
    {
        private IRestaurantFactory restaurant;

        public Client(IRestaurantFactory restaurant)
        {
            this.restaurant = restaurant;
        }

        public void OrderSalad()
        {
            ISalad salad = restaurant.OrderSalad(7);
            salad.Prepare();
        }

        public void OrderPizza()
        {
            IPizza pizza = restaurant.OrderPizza(10);
            pizza.Prepare();
        }

        public void OrderDessert()
        {
            IDessert dessert = restaurant.OrderDessert(15);
            dessert.Prepare();
        }
    }
}
