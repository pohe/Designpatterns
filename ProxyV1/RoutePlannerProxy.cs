using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyV1
{
    public class RoutePlannerProxy : IRoutePlanner
    {
        private RoutePlanner _planner;

        public RoutePlannerProxy()
        {
            _planner = null;
        }

        public PlanningResult CalculatePlan(PlanningData data)
        {
            InitPlanner();
            return _planner.CalculatePlan(data);
        }

        private void InitPlanner()
        {
            _planner = _planner ?? new RoutePlanner();
        }
    }

}
