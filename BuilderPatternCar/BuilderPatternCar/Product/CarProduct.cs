using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternCar.Product
{
    class Car
    {
        private string _carBrand;
        private Dictionary<string, string> _specs =
          new Dictionary<string, string>();

        public Car(string carBrand)
        {
            this._carBrand = carBrand;
        }

        public string this[string key]
        {
            get { return _specs[key]; }
            set { _specs[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Car Brand: {0}", _carBrand);
            Console.WriteLine(" Model : {0}", _specs["model"]);
            Console.WriteLine(" Color : {0}", _specs["color"]);
            Console.WriteLine(" Year: {0}", _specs["year"]);
        }
    }
}