using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoQ1
{
    internal class Force
    {
        //Fields

        private string obj1;
        private string obj2;
        private double massObj1;
        private double massObj2;
        private double distanceBewteenObjs;
        private double force;
        private const double gravConst = (6.67408e-11);

        //Accessors

        public string GetObj1()
        {
            return obj1;
        }
        public string GetObj2()
        {
            return obj2;
        }
        public double GetMassObj1()
        {
            return massObj1;
        }
        public double GetMassObj2()
        {
            return massObj2;
        }
        public double GetDistanceBewteenObjs()
        {
            return distanceBewteenObjs;
        }
        public double GetForce()
        {
            return force;
        }
        public string GetForceSummary()
        {
            return "The force between " + obj1 + " and " + obj2 + " is " + force + " newtons.";
        }
        public void ForceCalc()
        {
            force = gravConst * ((massObj1 * massObj2) / (distanceBewteenObjs * distanceBewteenObjs));
        }

        //Mutators

        public void SetObj1(string obj1)
        {
            this.obj1 = obj1;
        }
        public void SetObj2(string obj2)
        {
            this.obj2 = obj2;
        }
        public void SetMassObj1(double massObj1)
        {
            this.massObj1 = massObj1;
            ForceCalc();
        }
        public void SetMassObj2(double massObj2)
        {
            this.massObj2 = massObj2;
            ForceCalc();
        }
        public void SetDistanceBetweenObjs(double distanceBewteenObjs)
        {
            this.distanceBewteenObjs = distanceBewteenObjs;
            ForceCalc();
        }
        

        //Constructor
        public Force()
        {

        }
         
    }
}
