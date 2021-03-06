﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionV2
{
    class Program
    {
        public  static  bool myMethod(int i)
        {
            return i > 12 && i <= 35;
        }

        static void Main(string[] args)
        {
            Filter f = new Filter();
            List<int> someValues = new List<int>() {1, 15, 27, 3};
            List<int> filteredValues = f.FilterValues(someValues, v => v > 10);
            filteredValues = f.FilterValues(someValues, myMethod);

            foreach (var v in filteredValues){
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}
