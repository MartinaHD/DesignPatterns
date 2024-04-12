using System;

namespace Proxy.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarProxy proxy = new CarProxy();
            proxy.Drive("John");
            proxy.Drive("Alice");
            proxy.Drive("Alice");
            Console.ReadKey();
        }
    }

    public interface ICar
    {
        void Drive(string driverName);
    }

    public class Car : ICar
    {
        public void Drive(string driverName)
        {
            Console.WriteLine(driverName + " is driving the car.\n");
        }
    }

    public class CarProxy : ICar
    {
        private Car car = new Car();
        private string previousDriver = "";

        public void Drive(string driverName)
        {
            Console.WriteLine("Proxy is checking the driver's license for " + driverName + "...");
            if (driverName != previousDriver)
            {
                Console.WriteLine("Driver's license verified. Allowing " + driverName + " to drive.");
                car.Drive(driverName);
                previousDriver = driverName;
            }
            else
            {
                Console.WriteLine(driverName + " has already driven before. No need to re-verify license.");
                car.Drive(driverName);
            }
        }
    }
}