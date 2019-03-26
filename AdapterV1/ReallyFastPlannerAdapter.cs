using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodV2;

namespace AdapterV1
{
    public class ReallyFastPlannerAdapter : IPlanner
    {
        private ReallyFastPlannerV16 _adaptee;

        public ReallyFastPlannerAdapter()
        {
            _adaptee = new ReallyFastPlannerV16();
        }

        public PlanningResult CreatePlan(PlanningData data)
        {
            return _adaptee.CreatePlanFast(data);
        }
    }

}
