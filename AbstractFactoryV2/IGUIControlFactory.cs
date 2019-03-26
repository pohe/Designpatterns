using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryV1;

namespace AbstractFactoryV2
{
    public interface IGUIControlFactory
    {
        IWindow CreateWindow();
        IButton CreateButton();
        IIcon CreateIcon();
    }

}
