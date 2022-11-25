using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestExample
{
  public class CarDTO
    {
        public string Model { get; set; }
        public decimal BorderTax { get; set; }
        public decimal PollutionTax { get; set; }
        public decimal VatTax { get; set; }
    }
}
