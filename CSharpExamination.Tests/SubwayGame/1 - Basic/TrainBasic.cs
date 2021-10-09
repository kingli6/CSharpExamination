using CSharpExamination.Methods;
using CSharpExamination.Methods.SubwayGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpExamination.Tests.SubwayGame
{
    [TestClass]
    public class SubwayGameBasic
    {
        [TestMethod]
        public void FourCartsThreePassengers()
        {
            //var t = new SubwayTrain();

            //var p1 = new Passenger("Kalle");
            //var p2 = new Passenger("Jesus");
            //var p3 = new Passenger("Ola-Conny");

            //var w1 = new SubwayCart(capacity: 3);
            //var w2 = new SubwayCart(capacity: 3);
            //var w3 = new SubwayCart(capacity: 2);
            //var w4 = new SubwayCart(capacity: 1);

            //w1.AddPassenger(p1);
            //w1.AddPassenger(p2);
            //w2.AddPassenger(p3);

            //t.AddCart(w1);
            //t.AddCart(w2);
            //t.AddCart(w3);
            //t.AddCart(w4);

            //string description = t.GetTrainInfo();

            //Assert.AreEqual("This train has 4 carts and 3 passengers", description);
        }

        [TestMethod]
        public void FiveCartsTwoPassengers()
        {
            //var t = new SubwayTrain();

            //var p1 = new Passenger("Kalle");
            //var p2 = new Passenger("Jesus");

            //var w1 = new SubwayCart(3);
            //var w2 = new SubwayCart(3);
            //var w3 = new SubwayCart(2);
            //var w4 = new SubwayCart(1);
            //var w5 = new SubwayCart(1);

            //w1.AddPassenger(p1);
            //w5.AddPassenger(p2);

            //t.AddCart(w1);
            //t.AddCart(w2);
            //t.AddCart(w3);
            //t.AddCart(w4);
            //t.AddCart(w5);

            //string description = t.GetTrainInfo();

            //Assert.AreEqual("This train has 5 carts and 2 passengers", description);
        }

        [TestMethod]
        public void BoringTrain()
        {
            //var t = new SubwayTrain();
            //string description = t.GetTrainInfo();

            //Assert.AreEqual("This train has 0 carts and 0 passengers", description);
        }
    }
}