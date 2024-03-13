using System;
using System.Collections.Generic;

using BuilderPatternCar.Builder;
using BuilderPatternCar.ConcreteBuilder;
using BuilderPatternCar.Director;

class Program
{
    static void Main()
    {
        CarBuilder builder;

        Specifications specifications = new Specifications();

        builder = new ToyotaBuilder();
        specifications.Construct(builder);
        builder.Car.Show();

        builder = new HondaBuilder();
        specifications.Construct(builder);
        builder.Car.Show();

        builder = new PeugeotBuilder();
        specifications.Construct(builder);
        builder.Car.Show();

        Console.ReadKey();
    }
}