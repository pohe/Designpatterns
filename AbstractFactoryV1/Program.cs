using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryV1
{
    class Program
    {
        static void Main(string[] args)
        {
            GUIManager gm = new GUIManager(
                new WindowFactoryDefault(),
                new ButtonFactoryNature(),
                new IconFactoryIndustrial());

        }
    }
}
