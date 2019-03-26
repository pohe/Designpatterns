using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionV2
{
    class Filter
    {
        public List<int> FilterValues(List<int> values, Func<int, bool> criterion)
        {
            List<int> filteredValues = new List<int>();
            foreach (var value in values)
            {
                if (criterion(value))
                {
                    filteredValues.Add(value);
                }
            }
            return filteredValues;
        }

    }
}
