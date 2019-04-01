using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyV1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Første version
            IRoutePlanner planner = new RoutePlanner();
            PrepareForPlanning(planner);

            //Anden version - brug af Proxy
            IRoutePlanner plannerProxy = new RoutePlannerProxy();
            PrepareForPlanning(plannerProxy);

        }

        private static void PrepareForPlanning(IRoutePlanner p)
        {
            //We are not sure that we will use the planner

            bool condition = false;
            if (condition)
            {
                PlanningData data = new PlanningData();//load planning data
                p.CalculatePlan(data);
            }

        }
    }
}
