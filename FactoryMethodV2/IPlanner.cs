﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodV2
{
    public interface IPlanner
    {
        PlanningResult CreatePlan(PlanningData data);
    }

}
