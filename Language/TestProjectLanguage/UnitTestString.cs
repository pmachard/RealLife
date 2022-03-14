using NUnit.Framework;
using System;

namespace Utopia.Language.UnitTest
{
    public class UnitTestString
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreate()
        {
            string s = new String("azerty");
            Assert.NotNull(s);
        }
    }
}