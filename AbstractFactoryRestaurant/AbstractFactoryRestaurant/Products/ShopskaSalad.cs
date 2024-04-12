using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Products
{
    public class ShopskaSalad : ISalad
    {
        private int preparationTime;

        public ShopskaSalad(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Shopska Salad... It will takes {preparationTime} minutes.");
        }
    }
}
