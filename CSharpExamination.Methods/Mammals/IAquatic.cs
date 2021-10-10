using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamination.Methods.Mammals
{
    public interface IAquatic
    {
        Sex sex{get; set;}
        Diet diet{get; set;}
        string name{get; set;}
        int weight{get; set;}
        bool isHungry { get; set; }
        int maxTimeUnderWater { get; set; }
        int jumpingHeight { get; set; }
        bool IsAlive { get; set; }

        void Dive(int dive);
    }
}
