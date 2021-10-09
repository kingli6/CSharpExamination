using CSharpExamination.Methods;
using CSharpExamination.Methods.Mammals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharpExamination.Tests.Mammals
{
    [TestClass]
    public class IMarsupialBasic

    {
        [TestMethod]
        public void TransformFirstBabyToAdultAndAddToList()
        {
            //List<IMarsupial> kangarooBabies = new List<IMarsupial>() { new Kangaroo(sex: Sex.Male, name: "Ru", weight: 23, diet: Diet.Milk, isHungry: true, jumpingHeight: 2) };
            //List<IMarsupial> opossumBabies = new List<IMarsupial>() { new Opossum(sex: Sex.Male, name: "Pingu", weight: 23, diet: Diet.Milk, isHungry: true), new Opossum(sex: Sex.Male, name: "Pongo", weight: 23, diet: Diet.Milk, isHungry: true) };

            //IMarsupial kangaroo = new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2, babiesInPouch: kangarooBabies);
            //IMarsupial opossum = new Opossum(sex: Sex.Female, name: "Pungis", weight: 23, diet: Diet.Herbivore, isHungry: false, babiesInPouch: opossumBabies);

            //var expected = new Kangaroo(sex: Sex.Male, name: "Ru", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2);
            //IMarsupial result = kangaroo.TransformBabyToAdult();
            //Assert.AreEqual(expected.Name, (result as Kangaroo).Name);
            //Assert.AreEqual(expected.Diet, (result as Kangaroo).Diet);
            //Assert.AreEqual(0, kangaroo.BabiesInPouch.Count);

            //var expected2 = new Opossum(sex: Sex.Male, name: "Pingu", weight: 23, diet: Diet.Herbivore, isHungry: true);
            //IMarsupial result2 = opossum.TransformBabyToAdult();
            //Assert.AreEqual(expected2.Name, (result2 as Opossum).Name);
            //Assert.AreEqual(expected2.Diet, (result2 as Opossum).Diet);
            //Assert.AreEqual(1, opossum.BabiesInPouch.Count);
        }

        [TestMethod]
        public void TransformAllBabiesToAdultsAndAddToList()
        {
            //List<IMarsupial> marsupials = new List<IMarsupial>();
            //List<IMarsupial> kangarooBabies = new List<IMarsupial>() { new Kangaroo(sex: Sex.Male, name: "Ru", weight: 23, diet: Diet.Milk, isHungry: true, jumpingHeight: 2) };
            //List<IMarsupial> opossumBabies = new List<IMarsupial>() { new Opossum(sex: Sex.Male, name: "Pingu", weight: 23, diet: Diet.Milk, isHungry: true), new Opossum(sex: Sex.Male, name: "Pongo", weight: 23, diet: Diet.Milk, isHungry: true) };

            //marsupials.Add(new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2, babiesInPouch: kangarooBabies));
            //marsupials.Add(new Opossum(sex: Sex.Female, name: "Pungis", weight: 23, diet: Diet.Herbivore, isHungry: false, babiesInPouch: opossumBabies));

            //List<Mammal> expected = new List<Mammal>() {
            //    new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2),
            //    new Opossum(sex: Sex.Female, name: "Pungis", weight: 23, diet: Diet.Herbivore, isHungry: false),
            //    new Kangaroo(sex: Sex.Male, name: "Ru", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2),
            //    new Opossum(sex: Sex.Male, name: "Pingu", weight: 23, diet: Diet.Herbivore, isHungry: true),
            //    new Opossum(sex: Sex.Male, name: "Pongo", weight: 23, diet: Diet.Herbivore, isHungry: true)
            //};

            //var result = MammalMethods.TransformBabiesToAdults(marsupials);

            //Assert.AreEqual(expected[2].Name, (result[2] as Mammal).Name);
            //Assert.AreEqual(expected[2].Diet, (result[2] as Mammal).Diet);

            //Assert.AreEqual(expected[3].Name, (result[3] as Mammal).Name);
            //Assert.AreEqual(expected[3].Diet, (result[3] as Mammal).Diet);

            //Assert.AreEqual(expected[4].Name, (result[4] as Mammal).Name);
            //Assert.AreEqual(expected[4].Diet, (result[4] as Mammal).Diet);

            //Assert.AreEqual(0, marsupials[0].BabiesInPouch.Count);
            //Assert.AreEqual(0, marsupials[1].BabiesInPouch.Count);
        }

        [TestMethod]
        public void KangarooWithOpossumBabyThrowsException()
        {
            //try
            //{
            //    var kangaroo = new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2, babiesInPouch: new List<IMarsupial>() { new Opossum(sex: Sex.Male, name: "Pongo", weight: 23, diet: Diet.Milk, isHungry: true) });
            //    Assert.Fail();
            //}
            //catch (ArgumentException e)
            //{
            //    Assert.AreEqual("Wrong kind of marsupial!", e.Message);
            //}
        }

        [TestMethod]
        public void OpossumWithKangarooBabyThrowsException()
        {
            //try
            //{
            //    var opossum = new Opossum(sex: Sex.Female, name: "Pungis", weight: 23, diet: Diet.Herbivore, isHungry: false, babiesInPouch: new List<IMarsupial>() { new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2) });
            //    Assert.Fail();
            //}
            //catch (ArgumentException e)
            //{
            //    Assert.AreEqual("Wrong kind of marsupial!", e.Message);
            //}
        }
    }
}