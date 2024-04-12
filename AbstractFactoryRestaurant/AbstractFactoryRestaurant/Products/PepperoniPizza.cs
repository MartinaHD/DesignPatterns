using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Products
{
    public class PepperoniPizza : IPizza
    {
        private int preparationTime;

        public PepperoniPizza(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Pepperoni Pizza... It will takes {preparationTime} minutes.");
        }
    }
}
