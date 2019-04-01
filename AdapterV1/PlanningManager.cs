using FactoryMethodV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterV1
{
    public class PlanningManager
    {
        public void ExecutePlanning(int timeAvailable, IplannerFactory plannerFac)
        {
            PlanningData data = ReadPlanningDataFromDB();
            PlanningResult result = plannerFac.create(timeAvailable).CreatePlan(data);

            //if (timeAvailable < 3)
            //{
            //    ReallyFastPlannerAdapter rfpAdap = new ReallyFastPlannerAdapter();
            //    result = rfpAdap.CreatePlan(data);
            //}
            //else if (timeAvailable < 12)
            //{
            //    PrettyFastPlannerV24 pfp24 = new PrettyFastPlannerV24();
            //    result = pfp24.CreatePlan(data);
            //}
            //else
            //{
            //    ExactPlannerV37 ep37 = new ExactPlannerV37();
            //    result = ep37.CreatePlan(data);
            //}

            WritePlanningResultToDB(result);
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
