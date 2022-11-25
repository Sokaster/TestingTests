using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class CarStorage : ICarStorage
    {
        public List<Car> GetCars()
        {
            return new List<Car>()
            {
                new Car()
                { 
                Model = "406",
                Maker = "Peugeot",
                Year = 1999,
                EngineCapacity = 2000,
                Price = 6000
                }
             };
        }
    }
}

