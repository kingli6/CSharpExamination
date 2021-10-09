using CSharpExamination.Methods.SubwayGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CSharpExamination.Tests.SubwayGame
{
    [TestClass]
    public class SubwayGameAdvanced
    {
        [TestMethod]
        public void TrainGameNoCrash()
        {
            //Game game = new Game();

            //City a = new City();
            //City b = new City();
            //City c = new City();
            //City d = new City();
            //City e = new City();

            //SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c, d, e }, speed: 1);
            //SubwayTrain t2 = new SubwayTrain(name: "Train2", route: new List<City>() { c, d, e, a, b }, speed: 1);

            //game.Trains.Add(t1);
            //game.Trains.Add(t2);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //game.MoveTrains();
        }

        [TestMethod]
        public void TrainGameInstantCrash()
        {
            //Game game = new Game();

            //City a = new City();
            //City b = new City();
            //City c = new City();
            //City d = new City();
            //City e = new City();

            //SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c }, speed: 1);
            //SubwayTrain t2 = new SubwayTrain(name: "Train2", route: new List<City>() { c, b, a }, speed: 1);

            //game.Trains.Add(t1);
            //game.Trains.Add(t2);

            //game.MoveTrains();
            //Assert.IsTrue(t1.HasCrashed);
            //Assert.IsTrue(t2.HasCrashed);
        }

        [TestMethod]
        public void TrainGameCityWithMultipleTracks()
        {
            //Game game = new Game();

            //City a = new City(1);
            //City b = new City(2);
            //City c = new City(1);

            //SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c }, speed: 1);
            //SubwayTrain t2 = new SubwayTrain(name: "Train2", route: new List<City>() { c, b, a }, speed: 1);

            //game.Trains.Add(t1);
            //game.Trains.Add(t2);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);
        }

        [TestMethod]
        public void TrainGameCityWithMultipleTracksAndCrash()
        {
            //    Game game = new Game();

            //    City a = new City(1);
            //    City b = new City(2);
            //    City c = new City(2);

            //    SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c }, speed: 1);
            //    SubwayTrain t2 = new SubwayTrain(name: "Train2", route: new List<City>() { c, b, a }, speed: 1);
            //    SubwayTrain t3 = new SubwayTrain(name: "Train3", route: new List<City>() { c, b, a }, speed: 1);

            //    game.Trains.Add(t1);
            //    game.Trains.Add(t2);
            //    game.Trains.Add(t3);

            //    game.MoveTrains();
            //    Assert.IsTrue(t1.HasCrashed);
            //    Assert.IsTrue(t2.HasCrashed);
            //    Assert.IsTrue(t3.HasCrashed);
        }

        [TestMethod]
        public void TrainGameCityWithMultipleTracksAndOneFastTrain()
        {
            //Game game = new Game();

            //City a = new City(1);
            //City b = new City(2);
            //City c = new City(2);

            //SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c, b, a }, speed: 2);
            //SubwayTrain t2 = new SubwayTrain(name: "Train2", route: new List<City>() { c, b, c, a }, speed: 1);
            //SubwayTrain t3 = new SubwayTrain(name: "Train3", route: new List<City>() { c, b, a, b, c }, speed: 1);

            //game.Trains.Add(t1);
            //game.Trains.Add(t2);
            //game.Trains.Add(t3);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);
            //Assert.IsFalse(t3.HasCrashed);

            //game.MoveTrains();
            //Assert.IsTrue(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);
            //Assert.IsTrue(t3.HasCrashed);

            //game.MoveTrains();
            //Assert.IsTrue(t1.HasCrashed);
            //Assert.IsTrue(t2.HasCrashed);
            //Assert.IsTrue(t3.HasCrashed);
        }

        [TestMethod]
        public void TrainGameWithOneFastTrain()
        {
            //Game game = new Game();

            //City a = new City(1);
            //City b = new City(2);
            //City c = new City(2);

            //City d = new City(1);
            //City e = new City(2);
            //City f = new City(2);

            //SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c, b, a, d, e, f }, speed: 3);

            //game.Trains.Add(t1);

            //game.MoveTrains();
            //Assert.AreEqual(game.GetTrainLocation(t1), b);
            //game.MoveTrains();
            //Assert.AreEqual(game.GetTrainLocation(t1), e);
            //game.MoveTrains();
            //Assert.AreEqual(game.GetTrainLocation(t1), b);
            //game.MoveTrains();
            //Assert.AreEqual(game.GetTrainLocation(t1), a);
            //game.MoveTrains();
            //Assert.AreEqual(game.GetTrainLocation(t1), f);
        }

        [TestMethod]
        public void TrainGameWithTwoFastTrainsAndCrash()
        {
            //Game game = new Game();

            //City a = new City(1);
            //City b = new City(1);
            //City c = new City(1);
            //City d = new City(1);
            //City e = new City(1);
            //City f = new City(1);

            //SubwayTrain t1 = new SubwayTrain(name: "Train1", route: new List<City>() { a, b, c, b, e, f }, speed: 3);

            //SubwayTrain t2 = new SubwayTrain(name: "Train2", route: new List<City>() { e, f, c, f, b, a }, speed: 2);

            //game.Trains.Add(t1);
            //game.Trains.Add(t2);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsFalse(t1.HasCrashed);
            //Assert.IsFalse(t2.HasCrashed);

            //game.MoveTrains();
            //Assert.IsTrue(t1.HasCrashed);
            //Assert.IsTrue(t2.HasCrashed);
        }
    }
}