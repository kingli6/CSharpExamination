using CSharpExamination.Methods;
using CSharpExamination.Methods.Mammals;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpExamination.Tests.Mammals
{
    [TestClass]
    public class MammalsBasic
    {
        [TestMethod]
        public void FeedMammalsWithSameFood()
        {
            //List<Mammal> mammals = new List<Mammal>();
            //mammals.Add(new Fox(sex: Sex.Male, name: "Rävis", weight: 4.6, diet: Diet.Carnivore, isHungry: true, stuffItSays: new List<string> { "" }));
            //mammals.Add(new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2, babiesInPouch: new List<IMarsupial>()));
            //mammals.Add(new Hamster(sex: Sex.Female, name: "Hamstris", weight: 23, diet: Diet.Herbivore, isHungry: false));

            //List<string> expected = new List<string>() { "I don't like this food!", "Yum! Thank you!", "I don't want to eat right now." };

            //List<string> result = MammalMethods.AnimalFeeding(mammals, Diet.Herbivore);

            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FeedMammalsWithFoodList()
        {
            //List<Mammal> mammals = new List<Mammal>();
            //mammals.Add(new Fox(sex: Sex.Male, name: "Rävis", weight: 4.6, diet: Diet.Carnivore, isHungry: true, stuffItSays: new List<string> { "" }));
            //mammals.Add(new Kangaroo(sex: Sex.Female, name: "Kängu", weight: 23, diet: Diet.Herbivore, isHungry: true, jumpingHeight: 2, babiesInPouch: new List<IMarsupial>()));
            //mammals.Add(new Hamster(sex: Sex.Female, name: "Hamstris", weight: 23, diet: Diet.Milk, isHungry: false));

            //List<Diet> foodList = new List<Diet>() { Diet.Carnivore, Diet.Herbivore, Diet.Milk };

            //List<string> expected = new List<string>() { "Yum! Thank you!", "Yum! Thank you!", "I don't want to eat right now." };

            //List<string> result = MammalMethods.AnimalFeeding(mammals, foodList);

            //CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SpinHamster()
        {
            //Hamster hamster = new Hamster(sex: Sex.Male, name: "Hubert", weight: 1.2, diet: Diet.Herbivore, isHungry: false);
            //string expected = "Okay, I'm spinning spinning spinning spinning spinning spinning spinning spinning spinning spinning spinning spinning spinning spinning spinning around.";
            //string response = hamster.SpinWheel(15);
            //Assert.AreEqual(expected, response);
            //Assert.IsTrue(hamster.IsHungry);

            //Hamster hamster2 = new Hamster(sex: Sex.Female, name: "Hubertina", weight: 1.2, diet: Diet.Herbivore, isHungry: false);
            //string expected2 = "Okay, I'm spinning spinning spinning spinning around.";
            //string response2 = hamster2.SpinWheel(4);
            //Assert.AreEqual(expected2, response2);
            //Assert.IsFalse(hamster2.IsHungry);

            //Hamster hamster3 = new Hamster(sex: Sex.Male, name: "Hamstris", weight: 1.2, diet: Diet.Herbivore, isHungry: false);
            //string expected3 = "Okay, I'm spinning spinning spinning spinning spinning spinning spinning spinning spinning around.";
            //string response3 = hamster3.SpinWheel(9);
            //Assert.AreEqual(expected3, response3);
            //Assert.IsFalse(hamster3.IsHungry);
        }

        [TestMethod]
        public void WhatDoesTheFoxSay()
        {
            //Fox fox = new Fox(sex: Sex.Female, name: "Ylvis", weight: 44600, diet: Diet.Carnivore, isHungry: true, stuffItSays: new List<string>()
            //{ "Ring-ding-ding-ding-dingeringeding!", "Wa-pa-pa-pa-pa-pa-pow!", "Hatee-hatee-hatee-ho!", "Joff-tchoff-tchoffo-tchoffo-tchoff!" });

            //Assert.AreEqual("Ring-ding-ding-ding-dingeringeding!", fox.WhatDoesItSay());
            //Assert.AreEqual("Wa-pa-pa-pa-pa-pa-pow!", fox.WhatDoesItSay());
            //Assert.AreEqual("Hatee-hatee-hatee-ho!", fox.WhatDoesItSay());
            //Assert.AreEqual("Joff-tchoff-tchoffo-tchoffo-tchoff!", fox.WhatDoesItSay());
            //Assert.AreEqual("It is silent", fox.WhatDoesItSay());
            //Assert.AreEqual("It is silent", fox.WhatDoesItSay());
            //Assert.AreEqual("It is silent", fox.WhatDoesItSay());

            //Fox fox2 = new Fox(sex: Sex.Male, name: "Tystis", weight: 44600, diet: Diet.Carnivore, isHungry: true);

            //Assert.AreEqual("It is silent", fox2.WhatDoesItSay());
        }
    }
}