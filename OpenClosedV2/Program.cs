using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedV2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorV11 cal = new CalculatorV11();
            CalculatorV12 cal12 = new CalculatorV12();
            Client c = new Client(cal12);
        }
    }
}
