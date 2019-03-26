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
            Client c = new Client(cal);
        }
    }
}
