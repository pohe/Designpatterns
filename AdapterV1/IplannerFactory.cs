using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodV2;

namespace AdapterV1
{
    public interface IplannerFactory
    {
        IPlanner create(int time);
    }
}
