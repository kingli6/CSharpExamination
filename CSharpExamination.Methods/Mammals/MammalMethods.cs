using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamination.Methods.Mammals
{
    public class MammalMethods
    {
        public static void DiveWithAll(List<IAquatic> aquatics, int numberOfMinutes)
        {
            //if the object.maxTimeUnderWater is over numberOfMinutes
            //set object.IsAlive = false
            //else true;
            foreach (var item in aquatics)
            {
                if (item.maxTimeUnderWater > numberOfMinutes)
                {
                    item.IsAlive = true;
                }
                else
                    item.IsAlive = false;
            }
            //aquatics.Select(i => i.maxTimeUnderWater > numberOfMinutes ? i.IsAlive = true : i.IsAlive = false);
        }
    }
}
