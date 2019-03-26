namespace ChainOfResponsibility
{
    internal class HelpHandlerNoHelpFound : IHelpHandler
    {
        public void LookupAndDisplayHelp(Context c)
        {
            throw new System.NotImplementedException();
        }
    }
}