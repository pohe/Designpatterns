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
            IRoutePlanner plannerProxy = new RoutePlannerProxy();
            PrepareForPlanning(plannerProxy);

        }

        private static void PrepareForPlanning(IRoutePlanner plannerProxy)
        {
            throw new NotImplementedException();
        }
    }
}
