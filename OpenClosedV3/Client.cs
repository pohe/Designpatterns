using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedV3
{
    public class Client
    {
        public ICalculator _calculator;

        public Client(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public void ProcessData(Data d)
        {
            int result = _calculator.Calculate(d);
            //...

        }
    }
}
