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
        public void TestBoxing()
        {
            int num = 23;
            // boxing
            object obj = num;
            Assert.NotNull(obj);
        }

        [Test]
        public void TestUnBoxing()
        {
            object obj = 23;
            // unboxing
            int num = (int)obj;
            Assert.IsTrue(num.Equals(obj));
        }
    }
}