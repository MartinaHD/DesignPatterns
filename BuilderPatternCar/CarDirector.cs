using System;

class Specifications
{
    public void Construct(CarBuilder carBuilder)
    {
        carBuilder.BuildModel();
        carBuilder.BuildColor();
        carBuilder.BuildYear();
    }
}