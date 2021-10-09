using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExamination.Methods.Mammals
{
    public class Mammal : IAquatic
    {
        
        public Sex sex { get; set; }
        public Diet diet { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public bool isHungry { get;set; }
        public int maxTimeUnderWater { get; set; }
        public int jumpingHeight { get; set; }
        public bool IsAlive {get;set;}
         
    }
}
//{ get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

//public class Mammal
//{
//private string name;
//private int weight;
//private bool isHungry;
//private int maxTimeUnderWater;
//private int jumpingHeight;
//private Sex sex;
//private Diet diet;

//public Mammal(Sex sex,
//string name,
//int weight,
//Diet diet,
//bool isHungry,
//int maxTimeUnderWater,
//int jumpingHeight)
//{
//    this.diet = diet;
//    this.sex = sex;
//    this.name = name;
//    this.weight = weight;
//    this.isHungry = isHungry;
//    this.maxTimeUnderWater = maxTimeUnderWater;
//    this.jumpingHeight = jumpingHeight;
//}
