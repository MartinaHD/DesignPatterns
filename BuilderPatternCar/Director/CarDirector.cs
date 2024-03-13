using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BuilderPatternCar.Builder;

namespace BuilderPatternCar.Director
{
    class Specifications
    {
        public void Construct(CarBuilder carBuilder)
        {
            carBuilder.BuildModel();
            carBuilder.BuildColor();
            carBuilder.BuildYear();
        }
    }
}