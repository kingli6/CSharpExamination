using CSharpExamination.Methods;
using CSharpExamination.Methods.Mammals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace CSharpExamination.Tests.Mammals
{
    [TestClass]
    public class IAquaticBasic
    {
        [TestMethod]
        public void DiveWithAll()
        {
            List<IAquatic> aquatics = new List<IAquatic>(); //Should IAquatic have a empty list defined in it?
            aquatics.Add(new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4));
            aquatics.Add(new Whale(sex: Sex.Female, name: "Wailord", weight: 44600, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 90, jumpingHeight: 2));
            aquatics.Add(new Platypus(sex: Sex.Female, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: false, maxTimeUnderWater: 10));
            //    /* dont know what : is... sex: Sex.Male  -sex is a class?
            //                                                could be struct

            //     */
            MammalMethods.DiveWithAll(aquatics, numberOfMinutes: 9);
            Assert.IsFalse((aquatics[0] as Mammal).IsAlive);
            Assert.IsTrue((aquatics[1] as Mammal).IsAlive);
            Assert.IsTrue((aquatics[2] as Mammal).IsAlive);
        }

        //[TestMethod]
        //public void DivingWithDeadIAquaticThrowsException()
        //{
        //    IAquatic dolphin = new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4);
        //    dolphin.Dive(10);
        //    Assert.IsFalse((dolphin as Mammal).IsAlive);
        //    Assert.ThrowsException<InvalidOperationException>(() => dolphin.Dive(10));
        //}
    }
}
/*
 is dolphin a class? no, it's an object of IAquatic... but new Dolphin(sex... 
                                                        here Dolphin is a class with a constructor...
 */