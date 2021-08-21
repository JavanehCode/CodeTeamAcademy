using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace StringHelper.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void TestReverse()
        {
            string input = "CodeTeamAcademy";

            var actual = StringHelper.Reverse(input);

            var expected = "ymedacAmaeTedoC";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStats1()
        {
            string input = "1. This is a sentence\t to check stats, for each of character groups! 2.";

            var actual = StringHelper.GetCharacterStats(input);

            var expected = new CharacterStats()
            {
                Alpha = 51,
                Numeric = 2,
                Punctuations = 4,
                Whitespaces = 14
            };

            Assert.AreEqual(expected.Alpha, actual.Alpha);
            Assert.AreEqual(expected.Numeric, actual.Numeric);
            Assert.AreEqual(expected.Punctuations, actual.Punctuations);
            Assert.AreEqual(expected.Whitespaces, actual.Whitespaces);
        }

        [TestMethod]
        public void TestStats2()
        {
            string input = "2000 Words and counting";

            var actual = StringHelper.GetCharacterStats(input);

            var expected = new CharacterStats()
            {
                Alpha = 16,
                Numeric = 4,
                Punctuations = 0,
                Whitespaces = 3
            };

            Assert.AreEqual(expected.Alpha, actual.Alpha);
            Assert.AreEqual(expected.Numeric, actual.Numeric);
            Assert.AreEqual(expected.Punctuations, actual.Punctuations);
            Assert.AreEqual(expected.Whitespaces, actual.Whitespaces);
        }

        [TestMethod]
        public void TestCount()
        {
            string input = "This would be like this book. That would be great. Be aware";

            IEnumerable<(string word, int count)> actual = StringHelper.CountWords(input, WordsCountOrder.Descending);

            var expected = new[]
            {
                ("be", 3),
                ("this", 2),
                ("would", 2),
                ("aware", 1),
                ("book", 1),
                ("great", 1),
                ("like", 1),
                ("that", 1)
            };

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
