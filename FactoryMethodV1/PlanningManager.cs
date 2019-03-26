using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodV1
{
    public class PlanningManager
    {
        public void ExecutePlanning(int timeAvailable)
        {
            PlanningData data = ReadPlanningDataFromDB();
            PlanningResult result = null;

            if (timeAvailable < 3)
            {
                ReallyFastPlannerV16 rfp16 = new ReallyFastPlannerV16();
                result = rfp16.CreatePlanFast(data);
            }
            else if (timeAvailable < 12)
            {
                PrettyFastPlannerV24 pfp24 = new PrettyFastPlannerV24();
                result = pfp24.CalculatePlan(data);
            }
            else
            {
                ExactPlannerV37 ep37 = new ExactPlannerV37();
                result = ep37.FindExactSolution(data);
            }

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
