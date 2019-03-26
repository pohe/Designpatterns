using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodV2
{
    class Program
    {
        static void Main(string[] args)
        {
            PlanningManagerV2 pm = new PlanningManagerV2();
            pm.ExecutePlanning(GetAvailableTime(), new PlannerFactoryDay());


        }

        private static object GetAvailableTime()
        {
            throw new NotImplementedException();
        }
    }
}
