using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Products
{
    public class VegetarianPizza : IPizza
    {
        private int preparationTime;

        public VegetarianPizza(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Vegetarian Pizza... It will takes {preparationTime} minutes.");
        }
    }
}
