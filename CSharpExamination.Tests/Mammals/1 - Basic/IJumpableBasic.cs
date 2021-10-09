using CSharpExamination.Methods;
using CSharpExamination.Methods.Mammals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpExamination.Tests.Mammals
{
    [TestClass]
    public class IJumpableBasic
    {
        [TestMethod]
        public void JumpWithAll()
        {
            //List<IJumpable> jumpers = new List<IJumpable>();
            //jumpers.Add(new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4));
            //jumpers.Add(new Whale(sex: Sex.Female, name: "Wailord", weight: 44600, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 90, jumpingHeight: 2));
            //jumpers.Add(new Kangaroo(sex: Sex.Female, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: false, jumpingHeight: 10));

            //var expected = new List<string>() { "Okay, I will jump 3 meters up.", "I cannot jump that high.", "Okay, I will jump 3 meters up." };
            //var result = MammalMethods.JumpWithAll(jumpers, 3);
            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void JumpWithAllZeroHeight()
        {
            //List<IJumpable> jumpers = new List<IJumpable>();
            //jumpers.Add(new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4));
            //jumpers.Add(new Whale(sex: Sex.Female, name: "Wailord", weight: 44600, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 90, jumpingHeight: 2));
            //jumpers.Add(new Kangaroo(sex: Sex.Female, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: false, jumpingHeight: 10));

            //var expected = new List<string>() { "You mean keep swimming?", "You mean keep swimming?", "You mean stand still?" };
            //var result = MammalMethods.JumpWithAll(jumpers, 0);
            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void JumpWithAllNegativeHeight()
        {
            //List<IJumpable> jumpers = new List<IJumpable>();
            //jumpers.Add(new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4));
            //jumpers.Add(new Whale(sex: Sex.Female, name: "Wailord", weight: 44600, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 90, jumpingHeight: 2));
            //jumpers.Add(new Kangaroo(sex: Sex.Female, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: false, jumpingHeight: 10));

            //var expected = new List<string>() { "That's diving, not jumping.", "That's diving, not jumping.", "That's digging, not jumping." };
            //var result = MammalMethods.JumpWithAll(jumpers, -5);
            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void JumpWithNoHeight()
        {
            //IJumpable dolphin = new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4);

            //var result = dolphin.Jump();
            //Assert.AreEqual("How high?", result);
        }
    }
}