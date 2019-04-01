using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodV2;

namespace AdapterV1
{
    class PlannerFactoryCh: IplannerFactory
    {
        public IPlanner create(int timeAvailable)
        {
            if (timeAvailable < 3)
            {
                return  new ReallyFastPlannerAdapter();
               
            }
            else if (timeAvailable < 12)
            {
                return  new PrettyFastPlannerV24();
                
            }
            else
            {
                return  new ExactPlannerV37();
                
            }
        }
    }
}
