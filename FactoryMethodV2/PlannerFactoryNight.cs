using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodV2
{
    
    public class PlannerFactoryNight : IPlannerFactory
    {
        public IPlanner Create(int timeAvailable)
        {
            if (timeAvailable < 8)
            {
                return new ReallyFastPlannerV16();
            }
            else if (timeAvailable < 60)
            {
                return new PrettyFastPlannerV24();
            }
            else
            {
                return new ExactPlannerV37();
            }
        }
    }
}
