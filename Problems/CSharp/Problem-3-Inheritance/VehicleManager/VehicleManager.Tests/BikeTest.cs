using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VehicleManager.Tests
{
    [TestClass]
    public class BikeTest
    {
        [TestMethod]
        public void TestBikeProperties()
        {
            Bike bike = new Bike(model: "Émonda SLR 9 eTap", brand: Brands.Trek, buildYear: 2022, BrakeType.Disc);

            Assert.AreEqual("Émonda SLR 9 eTap", bike.Model);
            Assert.AreEqual(Brands.Trek, bike.Trek);
            Assert.AreEqual(2022, bike.BuildYear);
            Assert.AreEqual(BrakeType.Disc, bike.BrakeType);
        }
    }
}
