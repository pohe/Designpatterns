using AbstractFactoryV1;

namespace AbstractFactoryV2
{
    internal class GUIControlFactoryNature : IGUIControlFactory
    {
        public IWindow CreateWindow()
        {
            throw new System.NotImplementedException();
        }

        public IButton CreateButton()
        {
            throw new System.NotImplementedException();
        }

        public IIcon CreateIcon()
        {
            throw new System.NotImplementedException();
        }
    }
}