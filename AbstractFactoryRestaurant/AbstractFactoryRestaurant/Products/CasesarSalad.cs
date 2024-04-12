using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Products
{
    public class CaesarSalad : ISalad
    {
        private int preparationTime;

        public CaesarSalad(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Caesar Salad... It will takes {preparationTime} minutes.");
        }
    }
}
