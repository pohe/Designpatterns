using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodV2
{
    class PlanningManagerV2
    {
        public void ExecutePlanning(int timeAvailable, IPlannerFactory plannerFactory )
        {
            PlanningData data = ReadPlanningDataFromDB();

            PlanningResult result = plannerFactory.Create(timeAvailable).CreatePlan(data);

            //if (timeAvailable < 3)
            //{
            //    ReallyFastPlannerV16 rfp16 = new ReallyFastPlannerV16();
            //    result = rfp16.CreatePlanFast(data);
            //}
            //else if (timeAvailable < 12)
            //{
            //    PrettyFastPlannerV24 pfp24 = new PrettyFastPlannerV24();
            //    result = pfp24.CalculatePlan(data);
            //}
            //else
            //{
            //    ExactPlannerV37 ep37 = new ExactPlannerV37();
            //    result = ep37.FindExactSolution(data);
            //}

            WritePlanningResultToDB(result);
        }

        internal void ExecutePlanning(object v, PlannerFactoryNight plannerFactoryNight)
        {
            throw new NotImplementedException();
        }

        internal void ExecutePlanning(object v, PlannerFactoryDay plannerFactoryDay)
        {
            throw new NotImplementedException();
        }

        private void WritePlanningResultToDB(PlanningResult result)
        {
            throw new NotImplementedException();
        }

        private PlanningData ReadPlanningDataFromDB()
        {
            throw new NotImplementedException();
        }
    }

}
