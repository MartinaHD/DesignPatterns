using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRestaurant.Interfaces
{
    public interface IRestaurantFactory
    {
        ISalad OrderSalad(int preparationTime);
        IPizza OrderPizza(int preparationTime);
        IDessert OrderDessert(int preparationTime);
    }
}