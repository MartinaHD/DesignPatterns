using System;
using static System.Net.Mime.MediaTypeNames;

public abstract class Cake 
{
    private int numCakes;
    public int NumCakes
    {
        get { return numCakes; }
        set { numCakes = value; }
    }

    public abstract void MakeCake(); 
}

public class VanillaCake: Cake
{
    public VanillaCake(int numCakes)
    {
        this.NumCakes = numCakes;
    }
    
    public override void MakeCake() 
    {
        Console.WriteLine("---VANILLA CAKE---");
        Console.WriteLine("Number of cakes: {0}", NumCakes);
    } 
}

public class ChocolateCake : Cake
{
    public ChocolateCake(int numCakes)
    {
        this.NumCakes = numCakes;
    }

    public override void MakeCake()
    {
        Console.WriteLine("---CHOCOLATE CAKE---");
        Console.WriteLine("Number of cakes: {0}", NumCakes);
    }
}

public abstract class CakeDecorator : Cake 
{ 
    protected Cake cake;
    
    public CakeDecorator(Cake cake)
    {
        this.cake = cake;
    }

    public override void MakeCake()
    {
        cake.MakeCake();
    }
}

public class FrostingDecorator : CakeDecorator
{
    public FrostingDecorator(Cake cake)
        : base(cake) { }

    public override void MakeCake()
    {
        base.MakeCake();
        Console.WriteLine(" with frosting");
    }
}

public class SprinklesDecorator : CakeDecorator
{
    public SprinklesDecorator(Cake cake) 
        : base(cake) { }

    public override void MakeCake()
    {
        base.MakeCake();
        Console.WriteLine(" with sprinkles");
    }
}

public class FruitDecorator : CakeDecorator
{
    public FruitDecorator(Cake cake) 
        : base(cake) { }

    public override void MakeCake()
    {
        base.MakeCake();
        Console.WriteLine(" with fruits");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Cake vanillaCake = new VanillaCake(5);
        vanillaCake.MakeCake();

        Cake chocolateCake = new ChocolateCake(10);
        chocolateCake.MakeCake();

        Console.WriteLine("\nAdding frosting to vanilla cake:");

        CakeDecorator vanillaCakeWithFrosting = new FrostingDecorator(new VanillaCake(3));
        vanillaCakeWithFrosting.MakeCake();

        Console.WriteLine("\nAdding fruits to vanilla cake:");

        CakeDecorator fruitCakeWithFrosting = new FruitDecorator(new VanillaCake(2));
        fruitCakeWithFrosting.MakeCake();

        Console.WriteLine("\nAdding sprinkles to chocolate cake:");

        CakeDecorator chocolateCakeWithSprinkles = new SprinklesDecorator(chocolateCake);
        chocolateCakeWithSprinkles.MakeCake();

        Console.ReadKey();
    }
}