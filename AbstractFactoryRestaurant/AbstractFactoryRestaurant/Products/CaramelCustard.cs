using AbstractFactoryRestaurant.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Products
{
    public class CaramelCustard : IDessert
    {
        private int preparationTime;

        public CaramelCustard(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void Prepare()
        {
            Console.WriteLine($"Preparing Caramel Custard... It will takes {preparationTime} minutes.");
        }
    }
}
