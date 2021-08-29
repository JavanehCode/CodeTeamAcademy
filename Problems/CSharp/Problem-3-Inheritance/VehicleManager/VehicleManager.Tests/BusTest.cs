using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VehicleManager.Tests
{
    [TestClass]
    public class BusTest
    {

        [TestMethod]
        public void TestWheelsCount()
        {
            Bus bus = new Bus();

            Assert.AreTrue(bus.WheelsCount > 4);
        }

        [TestMethod]
        public void TestInheritenceHierarchy()
        {
            Bus benzBus = new Bus(model: "O-355", brand: Brands.Benz, buildYear: 1974);

            Assert.IsTrue(benzBus is Bus);
            Assert.IsNotNull(benzBus as Bus);

            Assert.IsTrue(benzBus is Vehicle);
            Assert.IsNotNull(benzBus as Vehicle);

            Assert.IsInstanceOfType(benzBus, typeof(Vehicle));
            Assert.IsNotInstanceOfType(benzBus, typeof(AirPlane));
        }


        [TestMethod]
        public void TestAccessBaseProperties()
        {
            Bus benzBus = new Bus(model: "O-355", brand: Brands.Benz, buildYear: 1974);

            Vehicle vehicle = benzBus;

            Assert.AreEqual("0-355", vehicle.Model);
            Assert.AreEqual(Brands.Benz, vehicle.Brand);
            Assert.AreEqual(1974, vehicle.BuildYear);
        }
    }
}
