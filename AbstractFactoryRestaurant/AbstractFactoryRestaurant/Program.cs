using AbstractFactoryRestaurant.ConcreteFactories;
using AbstractFactoryRestaurant.Interfaces;
using AbstractFactoryRestaurant.Restaurant;

class Program
{
    static void Main()
    {
        IRestaurantFactory italianRestaurant = new ItalianRestaurant();
        Client italianRestaurantClient = new Client(italianRestaurant);
        italianRestaurantClient.OrderSalad();
        italianRestaurantClient.OrderPizza();
        italianRestaurantClient.OrderDessert();

        Console.WriteLine(new string('=', 80));

        IRestaurantFactory bulgarianRestaurant = new BulgarianRestaurant();
        Client bulgarianRestaurantClient = new Client(bulgarianRestaurant);
        bulgarianRestaurantClient.OrderDessert();
        bulgarianRestaurantClient.OrderPizza();
        bulgarianRestaurantClient.OrderDessert();
    }
}