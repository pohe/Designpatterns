using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedV3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator cal = new CalculatorV11();
            Client c = new Client(cal);
        }
    }
}
