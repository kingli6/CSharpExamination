using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamination.Methods.Mammals
{
    public class Platypus : Mammal
    {
        public Platypus(
        Sex sex,
        Diet diet,
        string name,
        int weight,
        bool isHungry,
        int maxTimeUnderWater)
        {
            this.sex = sex;
            this.diet = diet;
            this.name = name;
            this.weight = weight;
            this.isHungry = isHungry;
            this.maxTimeUnderWater = maxTimeUnderWater;

        }
    }
}
