using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VehicleManager.Tests
{
    [TestClass]
    public class IMotorizedVehicleTest
    {

        [TestMethod]
        public void TestIMotorizedVehicleInterface()
        {
            IMotorizedVehicle motorizedVehicle = new Car();

            motorizedVehicle = new Bus();

            motorizedVehicle = new MotoCycle();

            motorizedVehicle = new Ship();

            motorizedVehicle = new Boat();

            motorizedVehicle = new AirPlane();
        }

        [TestMethod]
        public void TestInterfacesOfAClass()
        {
            Car tesla60D = new Car(model: "X 60D", brand: Brands.Tesla, buildYear: 2016, EngineType.Electrical, Seats: 6);

            Assert.IsTrue(tesla60D is IMotorizedVehicle);

            IMotorizedVehicle motorizedVehicle = tesla60D as IMotorizedVehicle;

            Assert.IsNotNull(motorizedVehicle);

            Assert.AreEqual(EngineType.Electrical, motorizedVehicle.Engine.Type);
        }
    }
}
