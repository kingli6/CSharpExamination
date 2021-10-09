using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamination.Methods.Mammals
{
    public class Dolphin : Mammal
    {
        public Dolphin(
        Sex sex,
        Diet diet,
        string name,
        int weight,
        bool isHungry,
        int maxTimeUnderWater,
        int jumpingHeight)
        {
            this.sex = sex;
            this.diet = diet;
            this.name = name;
            this.weight = weight;
            this.isHungry = isHungry;
            this.maxTimeUnderWater = maxTimeUnderWater;
            this.jumpingHeight = jumpingHeight;
            //IsAlive = true;
        }
    }
}
