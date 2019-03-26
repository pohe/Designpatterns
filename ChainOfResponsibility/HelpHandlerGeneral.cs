namespace ChainOfResponsibility
{
    internal class HelpHandlerGeneral : IHelpHandler
    {
        private IHelpHandler noHH;

        public HelpHandlerGeneral(IHelpHandler noHH)
        {
            this.noHH = noHH;
        }

        public void LookupAndDisplayHelp(Context c)
        {
            throw new System.NotImplementedException();
        }
    }
}