using NUnit.Framework;

using Utopia.Algo.Crypto.Implem;

namespace TestCrypto
{
    public class TestCrytoMd5
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestNull()
        {
            CrytoMd5 cMd5 = new CrytoMd5();
            string result = cMd5.crypt(null);
            Assert.IsNull(result);
        }

        [Test]
        public void TestEmpty()
        {
            CrytoMd5 cMd5 = new CrytoMd5();
            string result = cMd5.crypt("");
            Assert.NotNull(result);
        }

        [Test]
        public void TestStringOne()
        {
            CrytoMd5 cMd5 = new CrytoMd5();
            string result = cMd5.crypt("abc");
            Assert.AreEqual(string.Empty,result);
        }
    }
}