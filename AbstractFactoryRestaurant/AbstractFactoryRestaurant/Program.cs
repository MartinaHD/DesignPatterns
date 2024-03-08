using AbstractFactoryRestaurant.ConcreteFactories;
using AbstractFactoryRestaurant.Interfaces;

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

public enum DishType { Salad, Pizza, Dessert }
public enum Dish { ShopskaSalad, CaesarSalad, Pepperoni, Vegetarian, ChocolateCake, CaramelCustard }

public  class Salad
{
    private int preparationTime;

    public Salad(int preparationTime)
    {
        this.preparationTime = preparationTime;
    }
}

public class Pizza
{
    private int preparationTime;

    public Pizza(int preparationTime)
    {
        this.preparationTime = preparationTime;
    }
}

public class Dessert
{
    private int preparationTime;

    public Dessert(int preparationTime)
    {
        this.preparationTime = preparationTime;
    }
}

public class DishFactory
{
    public static object GetDish(Dish dishType, int preparationTime)
    {
        switch (dishType)
        {
            case Dish.ShopskaSalad:
            case Dish.CaesarSalad:
                return new Salad(preparationTime);

            case Dish.Pepperoni:
            case Dish.Vegetarian:
                return new Pizza(preparationTime);

            case Dish.ChocolateCake:
            case Dish.CaramelCustard:
                return new Dessert(preparationTime);

            default:
                throw new ArgumentException("Invalid dish type");
        }
    }
}
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

class Program
{
    static void Main()
    {
        IRestaurantFactory italianRestaurant = new ItalianRestaurant();
        ISalad italianSalad = italianRestaurant.OrderSalad(7);

        italianSalad.Prepare();

        IRestaurantFactory bulgarianRestaurant = new BulgarianRestaurant();
        IPizza bulgarianPizza = bulgarianRestaurant.OrderPizza(10);
        IDessert bulgarianDessert = bulgarianRestaurant.OrderDessert(15);

        bulgarianPizza.Prepare();
        bulgarianDessert.Prepare();

        /*Salad dish1 = DishFactory.GetDish(Dish.ShopskaSalad, 10);
        Console.WriteLine("Preparation time for Shopska Salad: {0} minutes", dish1.GetPreparationTime());

        Pizza dish2 = DishFactory.GetDish(Dish.Pepperoni, 20);
        Console.WriteLine("Preparation time for Pepperoni Pizza: {0} minutes", dish2.GetPreparationTime());

        Dessert dish3 = DishFactory.GetDish(Dish.ChocolateCake, 15);
        Console.WriteLine("Preparation time for Chocolate Cake: {0} minutes", dish3.GetPreparationTime());*/

        /*IRestaurantFactory italianRestaurant = new ItalianRestaurant();
        IRestaurantFactory bulgarianRestaurant = new BulgarianRestaurant();

        Client client1 = new Client(italianRestaurant);
        client1.OrderSalad();

        Client client2 = new Client(bulgarianRestaurant);
        client2.OrderPizza();
        client2.OrderDessert();*/
    }
}