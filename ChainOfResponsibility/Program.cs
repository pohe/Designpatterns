using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelpHandler noHH = new HelpHandlerNoHelpFound();
            IHelpHandler generalHH = new HelpHandlerGeneral(noHH);
            IHelpHandler detailedHH = new HelpHandlerDetailed(generalHH);
            // …hand reference to detailedHH to relevant parts of the application
            Context c = new Context();
            detailedHH.LookupAndDisplayHelp(c);
        }
    }
}
