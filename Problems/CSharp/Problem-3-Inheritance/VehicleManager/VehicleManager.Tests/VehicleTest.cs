using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VehicleManager.Tests
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void AssignToBaseClass()
        {
            Vehicle car = new Car();

            Vehicel bus = new Bus();

            Vehicle bike = new Bike();

            Vehicle motocycle = new MotoCycle();

            Vehicle ship = new Ship();

            Vehicel boat = new Boat();

            Vehicle airplane = new AirPlane();
        }

        [TestMethod]
        public void TestWithIs()
        {
            Assert.IsTrue(new Car() is Vehicle);
            Assert.IsTrue(new Bus() is Vehicle);
            Assert.IsTrue(new Bike() is Vehicle);
            Assert.IsTrue(new MotoCycle() is Vehicle);
            Assert.IsTrue(new Ship() is Vehicle);
            Assert.IsTrue(new AirPlane() is Vehicle);
        }

        [TestMethod]
        public void TestIPedalledVehicle()
        {
            TestIPedalledVehicle = new Bike();
        }

        [TestMethod]
        public void TestSeatCount()
        {
            AirPlane airPlane = new AirPlane();

            Vehicle vehicle = airPlane;

            Assert.IsTrue(vehicle.SeatCount > 0);
        }

        [TestMethod]
        public void TestAccessBaseProperties()
        {
            Bus benzBus = new Bus(model: "O-355", brand: Brands.Benz, buildYear: 1974, EngineType.Diesel, Seats: 44);

            Vehicle vehicle = benzBus;

            Assert.AreEqual("0-355", vehicle.Model);
            Assert.AreEqual(Brands.Benz, vehicle.Brand);
            Assert.AreEqual(1974, vehicle.BuildYear);
            Assert.AreEqual(44, vehicle.Seats);
        }
    }
}

