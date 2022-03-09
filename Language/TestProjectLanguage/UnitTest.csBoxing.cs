using NUnit.Framework;

namespace Utopia.Language.UnitTest
{
    public class UnitTestBoxing
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int value = 123;
            // boxes i
            object obj = value;
            // unboxi
            Assert.NotNull(obj);
        }
    }
}