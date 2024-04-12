
using RestaurantSimpleFactory;

try
{
    Dish shopskaSalad = DishFactory.GetDish(DishType.ShopskaSalad, 10);
    shopskaSalad.ShowPrepationTime(DishType.ShopskaSalad.ToString().SplitPascalCaseString());

    Dish pepperoni = DishFactory.GetDish(DishType.Pepperoni, 20);
    pepperoni.ShowPrepationTime(DishType.Pepperoni.ToString());

    Dish chocolateCake = DishFactory.GetDish(DishType.ChocolateCake, 15);
    chocolateCake.ShowPrepationTime(DishType.ChocolateCake.ToString().SplitPascalCaseString());

    Dish spaghetti = DishFactory.GetDish(DishType.Spaghetti, 40);
}
catch (Exception exception)
{
    if (exception is ArgumentException argumentException)
    {
        Console.WriteLine(argumentException.Message);
    }
}


