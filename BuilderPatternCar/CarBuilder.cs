using System;

abstract class CarBuilder
{
    protected Car car;

    public Car Car
    {
        get { return car; }
    }

    public abstract void BuildModel();
    public abstract void BuildColor();
    public abstract void BuildYear();
}