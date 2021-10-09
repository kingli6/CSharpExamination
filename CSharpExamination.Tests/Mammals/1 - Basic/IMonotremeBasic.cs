using CSharpExamination.Methods.Mammals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharpExamination.Tests.Mammals
{
    [TestClass]
    public class IMonotremeBasic
    {
        [TestMethod]
        public void HatchEggs()
        {
            //List<IMonotreme> monotremes = new List<IMonotreme>();
            //monotremes.Add(new Platypus(sex: Sex.Female, name: "Penny", weight: 3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10, numberOfEggs: 2));
            //monotremes.Add(new Platypus(sex: Sex.Male, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10));
            //monotremes.Add(new Echidna(sex: Sex.Female, name: "Edna", weight: 23, diet: Diet.Carnivore, isHungry: true, numberOfEggs: 1, numberOfSpikes: 123));
            //monotremes.Add(new Echidna(sex: Sex.Male, name: "Eddie", weight: 23, diet: Diet.Carnivore, isHungry: true, numberOfSpikes: 123));
            //List<string> names = new() { "Kenny", "Lenny", "Connie" };
            //List<Sex> sexes = new() { Sex.Male, Sex.Male, Sex.Female };

            //var result = MammalMethods.HatchAllEggs(monotremes, names, sexes);
            //monotremes.AddRange(result);
            //Assert.AreEqual("Kenny", (result[0] as Mammal).Name);
            //Assert.AreEqual("Lenny", (result[1] as Mammal).Name);
            //Assert.AreEqual("Connie", (result[2] as Mammal).Name);
            //Assert.AreEqual(Sex.Male, (result[0] as Mammal).Sex);
            //Assert.AreEqual(Sex.Male, (result[1] as Mammal).Sex);
            //Assert.AreEqual(Sex.Female, (result[2] as Mammal).Sex);
            //Assert.AreEqual(Diet.Milk, (result[0] as Mammal).Diet);
            //Assert.AreEqual(Diet.Milk, (result[1] as Mammal).Diet);
            //Assert.AreEqual(Diet.Milk, (result[2] as Mammal).Diet);

            //Assert.AreEqual(7, monotremes.Count);
        }

        [TestMethod]
        public void HatchWithNoEggsThrowsException()
        {
            //try
            //{
            //    var platypus = new Platypus(sex: Sex.Female, name: "Penny", weight: 3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10, numberOfEggs: 0);
            //    platypus.HatchEggs(new List<string>(), new List<Sex>());
            //}
            //catch (ArgumentException e)
            //{
            //    Assert.AreEqual("No eggs to hatch!", e.Message);
            //}
        }

        [TestMethod]
        public void HatchWithIncorrectInputThrowsException()
        {
            //try
            //{
            //    var platypus = new Echidna(sex: Sex.Female, name: "Penny", weight: 3, diet: Diet.Carnivore, isHungry: true, numberOfEggs: 2, numberOfSpikes: 123);
            //    platypus.HatchEggs(new List<string>() { "Torgny", "Felix" }, new List<Sex>() { Sex.Male, Sex.Female, Sex.Male });
            //}
            //catch (ArgumentException e)
            //{
            //    Assert.AreEqual("Invalid input", e.Message);
            //}
        }

        [TestMethod]
        public void CreatingMalePlatypusWithEggsThrowsException()
        {
            //try
            //{
            //    Platypus malePlatypus = new Platypus(sex: Sex.Male, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10, numberOfEggs: 2);
            //}
            //catch (ArgumentException e)
            //{
            //    Assert.AreEqual("Male platypus do not lay eggs.", e.Message);
            //}
        }

        [TestMethod]
        public void CreatingMaleEchidnaWithEggsThrowsException()
        {
            //try
            //{
            //    Echidna maleEchidna = new Echidna(sex: Sex.Male, name: "Eddie", weight: 3, diet: Diet.Carnivore, isHungry: true, numberOfEggs: 2, numberOfSpikes: 123);
            //}
            //catch (ArgumentException e)
            //{
            //    Assert.AreEqual("Male echidnas do not lay eggs.", e.Message);
            //}
        }
    }
}