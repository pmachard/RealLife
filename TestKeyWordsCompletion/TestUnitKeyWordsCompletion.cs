using NUnit.Framework;
using Utopia.Algo.KeyWordCompletion.Interface;
using Utopia.Algo.KeyWordCompletion.Implem;
using Utopia.Algo.KeyWordsCompletion.UnitTest.Mock;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest
{
    public class TestUnitKeyWordsCompletion
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCompareEqual()
        {
            IKeyWord word1 = new KeyWord<MockCompareKeyEqual>("polo");
            IKeyWord word2 = new KeyWord<MockCompareKeyEqual>("tata");

            Assert.AreEqual(100, word1.Compare(word1));
            Assert.AreEqual(0, word1.Compare(word2));
        }

        [Test]
        public void TestCompareAll0()
        {
            IKeyWord word1 = new KeyWord<MockCompareKeyAll0>("polo");
            IKeyWord word2 = new KeyWord<MockCompareKeyAll0>("tata");

            Assert.AreEqual(0, word1.Compare(word1));
            Assert.AreEqual(0, word1.Compare(word2));
        }

        [Test]
        public void TestCompareAll00()
        {
            IKeyWord word1 = new KeyWord<MockCompareKeyAll00>("polo");
            IKeyWord word2 = new KeyWord<MockCompareKeyAll00>("tata");

            Assert.AreEqual(100, word1.Compare(word1));
            Assert.AreEqual(100, word1.Compare(word2));
        }

        
        [Test]
        public void TestCompareCharEqual()
        {
            IKeyWord word1 = new KeyWord<MockCompareKeyCharEqual>("abcd");
            IKeyWord word2 = new KeyWord<MockCompareKeyCharEqual>("AbCD");

            Assert.AreEqual(100, word1.Compare(word1));
            Assert.AreEqual(100, word1.Compare(word2));
        }
    }
}