using NUnit.Framework;
using Utopia.Math.Symbolic.Interface;
using Utopia.Math.Symbolic.Implem;

namespace Utopia.Math.Symbolic.Test
{
    public class UnitTestMathSymbolicParser
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestExpEmpty()
        {
            IParser parser = new Parser();
            ISymbolExp exp = parser.Parse(string.Empty);
            Assert.IsNotNull(exp);

            exp = parser.Parse("");
            Assert.IsNotNull(exp);

            exp = parser.Parse(" ");
            Assert.IsNotNull(exp);
        }

        [Test]
        public void TestExpCreateTerm()
        {
            IParser parser = new Parser();
            ISymbolExp exp = parser.Parse("1.25");
            Assert.IsNotNull(exp);

            Assert.AreEqual(1.25, exp.Eval());
            Assert.AreEqual("1.25", exp.ToString());
        }
    }
}
