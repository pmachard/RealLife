using NUnit.Framework;
using Utopia.Algo.KeyWordCompletion.Interface;
using Utopia.Algo.KeyWordCompletion.Implem;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest
{
    public class TestUnitKeyWordsCompletion
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSimpleCheck()
        {
            Assert.IsNotNull(new KeyWord<string>());
            Assert.IsNotNull(new KeyWord<string>("toto"));
        }

    }
}