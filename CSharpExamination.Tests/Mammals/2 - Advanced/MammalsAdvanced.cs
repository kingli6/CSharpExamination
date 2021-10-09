using CSharpExamination.Methods;
using CSharpExamination.Methods.Mammals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpExamination.Tests.Mammals
{
    [TestClass]
    public class MammalsAdvanced
    {
        //static public List<Mammal> GetAllTheAnimals()
        //{
        //List<Mammal> allTheAnimals = new List<Mammal>();
        //allTheAnimals.Add(new Dolphin(sex: Sex.Male, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4));
        //allTheAnimals.Add(new Dolphin(sex: Sex.Female, name: "Dolphina", weight: 18, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4));
        //allTheAnimals.Add(new Whale(sex: Sex.Female, name: "Wailord", weight: 44600, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 90, jumpingHeight: 2));
        //allTheAnimals.Add(new Platypus(sex: Sex.Female, name: "Penny", weight: 2.3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10, numberOfEggs: 3));
        //allTheAnimals.Add(new Platypus(sex: Sex.Male, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10));
        //allTheAnimals.Add(new Echidna(sex: Sex.Female, name: "Edna", weight: 23, diet: Diet.Carnivore, isHungry: true, numberOfEggs: 8, numberOfSpikes: 123));
        //allTheAnimals.Add(new Echidna(sex: Sex.Male, name: "Edna", weight: 23, diet: Diet.Carnivore, isHungry: true, numberOfSpikes: 123));
        //allTheAnimals.Add(new Fox(sex: Sex.Female, name: "Ylvis", weight: 9, diet: Diet.Carnivore, isHungry: true, stuffItSays: new List<string>()
        //{ "Ring-ding-ding-ding-dingeringeding!", "Wa-pa-pa-pa-pa-pa-pow!", "Hatee-hatee-hatee-ho!", "Joff-tchoff-tchoffo-tchoffo-tchoff!" }));
        //allTheAnimals.Add(new Fox(sex: Sex.Male, name: "Tystis", weight: 12, diet: Diet.Carnivore, isHungry: true, stuffItSays: new List<string>()));
        //allTheAnimals.Add(new Hamster(sex: Sex.Female, name: "Perry", weight: 3, diet: Diet.Herbivore, isHungry: false));
        //allTheAnimals.Add(new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 30, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2, babiesInPouch: new List<IMarsupial>()
        //{ new Kangaroo(sex: Sex.Female, name: "Mini", weight: 3, diet: Diet.Milk, isHungry: true, jumpingHeight: 0) }));
        //allTheAnimals.Add(new Kangaroo(sex: Sex.Male, name: "Ru", weight: 36, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 4));
        //allTheAnimals.Add(new Opossum(sex: Sex.Female, name: "Oprah", weight: 3, diet: Diet.Herbivore, isHungry: true, babiesInPouch: new List<IMarsupial>()
        //{ new Opossum(sex: Sex.Male, name: "Winfrey", weight: 3, diet: Diet.Milk, isHungry: false),
        //  new Opossum(sex: Sex.Female, name: "Winny", weight: 3, diet: Diet.Milk, isHungry: true) }));

        //return allTheAnimals;
        //}

        [TestMethod]
        public void JumpWithThoseWhoCan()
        {
            //var allTheAnimals = GetAllTheAnimals();
            //List<string> expected = new List<string>() { "Okay, I will jump 4 meters up.", "Okay, I will jump 4 meters up.", "I cannot jump that high.", "I cannot jump that high.", "Okay, I will jump 4 meters up." };
            //List<string> response = MammalMethods.JumpWithThoseWhoCan(allTheAnimals, 4);
            //CollectionAssert.AreEqual(expected, response);
        }

        [TestMethod]
        public void GetAquaticsAndSortByWeight()
        {
            //var allTheAnimals = GetAllTheAnimals();
            //List<IAquatic> expected = new List<IAquatic>() {
            //    new Platypus(sex: Sex.Female, name: "Penny", weight: 2.3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10, numberOfEggs: 3),
            //    new Platypus(sex: Sex.Male, name: "Perry", weight: 3, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 10),
            //    new Dolphin(sex: Sex.Female, name: "Dolphina", weight: 18, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4),
            //    new Dolphin(sex: Sex.Female, name: "Dolph", weight: 23, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 8, jumpingHeight: 4),
            //    new Whale(sex: Sex.Female, name: "Wailord", weight: 44600, diet: Diet.Carnivore, isHungry: true, maxTimeUnderWater: 90, jumpingHeight: 2)};

            //var sortedAquatics = MammalMethods.GetAquaticsAndSortByWeight(allTheAnimals);
            //for (int i = 0; i < expected.Count; i++)
            //{
            //    Assert.AreEqual((expected[i] as Mammal).Name, (sortedAquatics[i] as Mammal).Name);
            //}
        }

        [TestMethod]
        public void ListenToTheFoxes()
        {
            //var allTheAnimals = GetAllTheAnimals();
            //List<string> expected = new List<string>() { "Ring-ding-ding-ding-dingeringeding!", "Wa-pa-pa-pa-pa-pa-pow!", "Hatee-hatee-hatee-ho!", "Joff-tchoff-tchoffo-tchoffo-tchoff!", "It is silent" };
            //List<string> result = MammalMethods.ListenToTheFoxes(allTheAnimals);
        }

        [TestMethod]
        public void FeedMarsupialBabies()
        {
            //var allTheAnimals = GetAllTheAnimals();
            //List<string> expected = new List<string>() { "Thank you for feeding my baby!", "My baby is not hungry right now.", "Thank you for feeding my baby!" };
            //List<string> result = MammalMethods.FeedMarsupialBabies(allTheAnimals, Diet.Milk);
            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FeedMarsupialBabiesWrongDiet()
        {
            //IMarsupial kangaroo = new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 30, diet: Diet.Carnivore, isHungry: true, jumpingHeight: 2, babiesInPouch: new List<IMarsupial>()
            //{ new Kangaroo(sex: Sex.Female, name: "Mini", weight: 3, diet: Diet.Milk, isHungry: true, jumpingHeight: 0) });

            //List<string> expected = new List<string>() { "My baby can't eat this." };
            //List<string> result = kangaroo.FeedBabies(Diet.Carnivore);
            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FeedAllTheAnimalsAndTheBabies()
        {
            //var allTheAnimals = GetAllTheAnimals();

            //List<string> expected = new List<string>() { "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't like this food!", "I don't want to eat right now.", "Yum! Thank you!", "My baby can't eat this.", "Yum! Thank you!", "Yum! Thank you!", "My baby can't eat this.", "My baby can't eat this." };
            //List<string> result = MammalMethods.FeedAllTheAnimalsAndBabies(allTheAnimals, Diet.Herbivore);

            //CollectionAssert.AreEqual(expected, result);
        }
    }
}