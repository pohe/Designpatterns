using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            //Profile pA = new Profile("Alice", 14);

            ProfileFactory pFac = new ProfileFactory();
            Profile pA = pFac.Create("Poul", 14);
            Profile pB = pFac.Create("Peter", 14);
            Profile pC = pFac.Create("Vibeke", 14);

            pC.Display();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
