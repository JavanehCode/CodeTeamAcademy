using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SellsManager.Tests
{
    [TestClass]
    public class TestSellsStatsProvider
    {
        [TestMethod]
        public void TestMostSoldProduct()
        {
            var inputFile = @"Data\Data10.csv";

            IEnumerable<SellRecord> sells = ReadSells(inputFile);

            SellsStatsProvider statsProvider = new SellsStatsProvider(sells);

            (int productId, int quantity) = statsProvider.GetMostSoldProduct();

            Assert.AreEqual(1016, productId);
            Assert.AreEqual(1145, quantity);
        }

        [TestMethod]
        public void TestTotalSellsPrice()
        {
            var inputFile = @"Data\Data10.csv";

            IEnumerable<SellRecord> sells = ReadSells(inputFile);

            SellsStatsProvider statsProvider = new SellsStatsProvider(sells);

            decimal totalSellsPrice = statsProvider.GetTotalSellsPrice();

            Assert.AreEqual(213620626, totalSellsPrice);
        }

        [TestMethod]
        public void TestCheapestSoldProduct()
        {
            var inputFile = @"Data\Data10.csv";

            IEnumerable<SellRecord> sells = ReadSells(inputFile);

            SellsStatsProvider statsProvider = new SellsStatsProvider(sells);

            (int productId, decimal avgSellPrice) = statsProvider.GetCheapestSoldProduct();

            Assert.AreEqual(309, avgSellPrice);
            Assert.AreEqual(1011, productId);
        }

        [TestMethod]
        public void TestMostConsecutiveSoldProduct()
        {
            IEnumerable<SellRecord> sells = new[]
            {
                new SellRecord()
                {
                    ProductId = 1,
                    Quantity = 100,
                },
                new SellRecord()
                {
                    ProductId = 5,
                    Quantity = 200
                },
                new SellRecord()
                {
                    ProductId = 5,
                    Quantity = 20,
                },
                new SellRecord()
                {
                    ProductId = 1,
                    Quantity  = 60,
                },
                new SellRecord()
                {
                    ProductId = 5,
                    Quantity = 210
                },
                new SellRecord()
                {
                    ProductId = 3,
                    Quantity = 80
                }
            };

            SellsStatsProvider statsProvider = new SellsStatsProvider(sells);

            (int productId, int consecutiveSoldQuantity) = statsProvider.GetMostConsecutiveSoldQuantity();

            Assert.AreEqual(220, consecutiveSoldQuantity);
            Assert.AreEqual(5, productId);
        }

        [TestMethod]
        public void TestMostInflatedProduct()
        {
            IEnumerable<SellRecord> sells = new[]
            {
                new SellRecord()
                {
                    RecordNumber = 1,
                    ProductId = 1,
                    Quantity = 100,
                },
                new SellRecord()
                {
                    RecordNumber = 2,
                    ProductId = 6,
                    Quantity = 100
                },
                new SellRecord()
                {
                    RecordNumber = 3,
                    ProductId = 1,
                    Quantity = 20,
                },
                new SellRecord()
                {
                    RecordNumber = 4,
                    ProductId = 6,
                    Quantity  = 120,
                },
                new SellRecord()
                {
                    RecordNumber = 5,
                    ProductId = 6,
                    Quantity = 210
                },
                new SellRecord()
                {
                    RecordNumber = 6,
                    ProductId = 8,
                    Quantity = 30
                },
                new SellRecord()
                {
                    RecordNumber = 7,
                    ProductId = 8,
                    Quantity = 40
                }
            };

            SellsStatsProvider statsProvider = new SellsStatsProvider(sells);

            int productId = statsProvider.GetMostInflatedProduct();

            Assert.AreEqual(8, productId);
        }

        private IEnumerable<SellRecord> ReadSells(string inputFile)
        {
            CSVReader csvReader = new CSVReader();

            csvReader.ReadData(inputFile);

            return csvReader.Sells;
        }
    }
}