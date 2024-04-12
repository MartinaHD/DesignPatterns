using static ProductFactory;

public class ProductFactory
{
    private Dictionary<string, Product> products = new Dictionary<string, Product>();

    public Product GetProduct(string key)
    {
        Product product = null;
        if (products.ContainsKey(key))
        {
            product = products[key];
        }
        else
        {
            switch (key)
            {
                case "Phone": product = new Phone(); 
                    break;
                case "Laptop": product = new Laptop(); 
                    break;
                case "Tablet": product = new Tablet(); 
                    break;
            }
            products.Add(key, product);
        }
        return product;
    }

    public abstract class Product
    {
        protected string name;
        protected double price;

        public abstract void Display();
    }

    public class Phone : Product
    {
        public Phone()
        {
            name = "Phone";
            price = 500.00;
        }

        public override void Display()
        {
            Console.WriteLine(name + " (Price: $" + price + ")");
        }
    }

    public class Laptop : Product
    {
        public Laptop()
        {
            name = "Laptop";
            price = 1000.00;
        }

        public override void Display()
        {
            Console.WriteLine(name + " (Price: $" + price + ")");
        }
    }

    public class Tablet : Product
    {
        public Tablet()
        {
            name = "Tablet";
            price = 300.00;
        }

        public override void Display()
        {
            Console.WriteLine(name + " (Price: $" + price + ")");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<string> products = new List<string> { "Phone", "Laptop", "Phone", "Tablet", "Laptop" };
        ProductFactory factory = new ProductFactory();

        foreach (string product in products)
        {
            Product prod = factory.GetProduct(product);
            prod.Display();
        }
        Console.ReadKey();
    }
}