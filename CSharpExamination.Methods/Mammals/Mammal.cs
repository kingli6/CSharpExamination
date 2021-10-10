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

        public void Dive(int dive)
        {
            try
            {
                if (maxTimeUnderWater < dive)
                {
                    IsAlive = false;
                }
            }
            catch (InvalidOperationException e)
            {
                throw new InvalidOperationException();
            }
            
            
        }
        /*
         
            //we need to check with the object
            //object.maxtimeunderwater.... last method we passed a list with all the objects,
            //  can we do the same here?
            //how do we check with dolphin object    ((using IAquatic dolphin as type..
            //if (dive == null || dive <= 0)
            //{
            //    throw new InvalidOperationException();
            //}
            
         */
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
