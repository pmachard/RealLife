using NUnit.Framework;

namespace Utopia.Language.SimpleConcept.UnitTest
{
    public class TestUnitString
    {
        [SetUp]
        public void Setup()
        {
        }

        public void TestConstrorSimple()
        {
            string s = null;
            Assert.IsNull(s);

            s = string.Empty;
            Assert.AreEqual(string.Empty, s);
            Assert.AreEqual(0, s.Length);

            s = "azerty";
            Assert.IsNotNull(s);
        }

        public void TestAdd()
        {
            string s1 = "Hello";
            string s2 = " World";
            Assert.NotNull(s1+s2);
            Assert.AreEqual("Hello World", s1 + s2);
            Assert.AreEqual("Hello World", string.Concat(s1, s2));
            Assert.AreEqual("Hello World", "{s1}{s2}");
        }
    }
}
