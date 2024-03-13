using System;

class ToyotaBuilder : CarBuilder
{
    public ToyotaBuilder()
    {
        car = new Car("Toyota");
    }

    public override void BuildModel()
    {
        car["model"] = "Yaris";
    }

    public override void BuildColor()
    {
        car["color"] = "Blue";
    }

    public override void BuildYear()
    {
        car["year"] = "2019";
    }
}

class HondaBuilder : CarBuilder
{
    public HondaBuilder()
    {
        car = new Car("Honda");
    }

    public override void BuildModel()
    {
        car["model"] = "Prologue";
    }

    public override void BuildColor()
    {
        car["color"] = "Metallic";
    }

    public override void BuildYear()
    {
        car["year"] = "2016";
    }
}

class PeugeotBuilder : CarBuilder
{
    public PeugeotBuilder()
    {
        car = new Car("Renault");
    }

    public override void BuildModel()
    {
        car["model"] = "Talisman";
    }

    public override void BuildColor()
    {
        car["color"] = "Red";
    }

    public override void BuildYear()
    {
        car["year"] = "2020";
    }
}