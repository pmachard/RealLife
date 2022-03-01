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
            IKeyWord word1 = new MockKeyWord<MockCompareKeyEqual>("polo");
            IKeyWord word2 = new MockKeyWord<MockCompareKeyEqual>("tata");

            Assert.AreEqual(null, word1.Compare(word1));
            Assert.AreEqual(null, word1.Compare(word2));
        }

        [Test]
        public void TestCompareAll0()
        {
            IKeyWord word1 = new KeyWordSet<MockCompareKeyAll0>("polo");
            IKeyWord word2 = new KeyWordSet<MockCompareKeyAll0>("tata");

            Assert.AreEqual(0, word1.Compare(word1));
            Assert.AreEqual(0, word1.Compare(word2));
        }

        [Test]
        public void TestCompareAll00()
        {
            IKeyWord word1 = new KeyWordSet<MockCompareKeyAll00>("polo");
            IKeyWord word2 = new KeyWordSet<MockCompareKeyAll00>("tata");

            Assert.AreEqual(100, word1.Compare(word1));
            Assert.AreEqual(100, word1.Compare(word2));
        }

        
        [Test]
        public void TestCompareCharEqual()
        {
            IKeyWord word1 = new KeyWordSet<MockCompareKeyCharEqual>("abcd");
            IKeyWord word2 = new KeyWordSet<MockCompareKeyCharEqual>("AbCD");

            Assert.AreEqual(100, word1.Compare(word1));
            Assert.AreEqual(100, word1.Compare(word2));
        }
    }
}