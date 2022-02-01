//Name: Andrew Montano
//Email: amontano59@cnm.edu
//File name: MontanoQ1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother = "";
            do
            {
                Force st = new Force();
                string obj1 = GetInput("What is the name of the first obj?: ");
                st.SetObj1(obj1);
                string obj2 = GetInput("What is the name of the second obj?: ");
                st.SetObj2(obj2);
                double massObj1 = double.Parse(GetInput("What is the mass of obj1 in kilograms?: "));
                st.SetMassObj1(massObj1);
                double massObj2 = double.Parse(GetInput("What is the mass of obj2 in kilograms?: "));
                st.SetMassObj2(massObj2);
                double distanceBewtweenObjs = double.Parse("What is the distance between the objects in meters?: ");
                st.SetDistanceBetweenObjs(distanceBewtweenObjs);

                Console.WriteLine(st.GetForceSummary());

                Console.WriteLine("Try two different objects? y/n: ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");   
        }

        private static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}
