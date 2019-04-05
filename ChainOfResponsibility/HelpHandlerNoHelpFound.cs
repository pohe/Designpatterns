namespace ChainOfResponsibility
{
    internal class HelpHandlerNoHelpFound : IHelpHandler
    {

        public HelpHandlerNoHelpFound(IHelpHandler nextHandler = null)
        {
            NextHandler = nextHandler;
        }

        public IHelpHandler NextHandler { get; set; }


        public void LookupAndDisplayHelp(Context c)
        {
            DisplayHelp();
        }

        public void DisplayHelp()
        {
            // Show website}
        }
    }
}