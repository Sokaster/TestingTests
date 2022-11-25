using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
    public class CarShop
    {
        private readonly ICarStorage _carStorage;
        public CarShop(ICarStorage carStorage)
        {
            _carStorage = carStorage;
        }
        public List<CarDTO> GetCarsInfo()
        {
            var taxCalculator = new TaxCalculator();
            var cars = _carStorage.GetCars();

            return cars.Select(q =>
            {
                var taxes = taxCalculator.Calculate(q);
                var car = new CarDTO
                {
                    Model = q.Model,
                    BorderTax = taxes.BorderTax,
                    PollutionTax = taxes.PollutionTax,
                    VatTax = taxes.VatTax
                };
                return car;
            }).ToList();
        }
    }
}
