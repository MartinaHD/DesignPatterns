using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

using BuilderPatternCar.Product;

namespace BuilderPatternCar.Builder
{
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
}