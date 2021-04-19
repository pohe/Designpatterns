using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedV2
{
    public class Client
    {
        public CalculatorV10 _calculator;
        public Client(CalculatorV10 calculator)
        {
            _calculator = calculator;
        }

        //public Client()
        //{ 
        //    _calculator = new CalculatorV10();
        //}

        public void ProcessData(Data d)
        {
            int result = _calculator.Calculate(d);
            //...
        }
    }


}
