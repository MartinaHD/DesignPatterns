using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Products
{
    public class ChocolateCake : IDessert
    {
        private int preparationTime;

        public ChocolateCake(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Chocolate Cake... It will takes {preparationTime} minutes.");
        }
    }
}
