using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class HelpHandlerDetailed : IHelpHandler
    {
        public HelpHandlerDetailed(IHelpHandler nextHandler = null)
        {
            NextHandler = nextHandler;
        }

        public IHelpHandler NextHandler { get; set; }

        public void LookupAndDisplayHelp(Context c) 
        {
            HelpInfo info = FindDetailedHelp(c);
            if (info != null) // Help found!
            {
                DisplayHelp(info);
            }
            else
            {
                NextHandler?.LookupAndDisplayHelp(c);
            }
        }

        public HelpInfo FindDetailedHelp(Context c)
        {
            // Code for Loking up detailed help
            return null;
        }

        public void DisplayHelp(HelpInfo h)
        {
            // Show help on screen }
        }
    }
}
