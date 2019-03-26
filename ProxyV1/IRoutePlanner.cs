using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyV1
{
    public interface IRoutePlanner
    {
        PlanningResult CalculatePlan(PlanningData data);
    }

}
