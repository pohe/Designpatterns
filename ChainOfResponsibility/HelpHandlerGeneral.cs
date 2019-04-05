namespace ChainOfResponsibility
{
    internal class HelpHandlerGeneral : IHelpHandler
    {
        private IHelpHandler NextHandler;

        public HelpHandlerGeneral(IHelpHandler noHH)
        {
            this.NextHandler = noHH;
        }

        public void LookupAndDisplayHelp(Context c)
        {
            HelpInfo info = FindGeneralHelp(c);
            if (info != null) // Help found!
            {
                DisplayHelp(info);
            }
            else
            {
                NextHandler?.LookupAndDisplayHelp(c);
            }
        }

        public HelpInfo FindGeneralHelp(Context c)
        {
            // Code for Loking up general help
            return null;
        }

        public void DisplayHelp(HelpInfo h)
        {
            // Show help on screen }
        }
    }
}