using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimpleFactory
{
    public abstract class Dish
    {
        private const string PREPARATION_TIME_DETAILS = "Preparation time for {0}: {1} minutes";

        private int preparationTime;

        public Dish(int preparationTime)
        {
            this.preparationTime = preparationTime;
        }

        public void ShowPrepationTime(string dishType)
        {
            Console.WriteLine(string.Format(PREPARATION_TIME_DETAILS, dishType, preparationTime));
        }
    }
}
