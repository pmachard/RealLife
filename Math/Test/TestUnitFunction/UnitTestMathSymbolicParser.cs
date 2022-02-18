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
        public void TestExpCheckEmpty()
        {
            IParser parser = new Parser();

            Assert.IsFalse(parser.Check(null));
            Assert.IsFalse(parser.Check(string.Empty));
            Assert.IsFalse(parser.Check(""));
            Assert.IsFalse(parser.Check(" "));
            Assert.IsFalse(parser.Check("  "));
            Assert.IsFalse(parser.Check("   "));
            Assert.IsFalse(parser.Check("   "));
        }

        [Test]
        public void TestExpCheckExcludeUpper()
        {
            IParser parser = new Parser();

            Assert.IsTrue(parser.Check("x"));
            Assert.IsFalse(parser.Check("X"));
            Assert.IsTrue(parser.Check("x+ y"));
            Assert.IsFalse(parser.Check("x+ Y"));
            Assert.IsTrue(parser.Check("x + y*2+(z^2+ 10.33)"));
            Assert.IsFalse(parser.Check("x + Y*2+(Z^2+ 10.33)"));
        }

        [Test]
        public void TestExpCheckVarName()
        {
            IParser parser = new Parser();
            Assert.IsTrue(parser.Check("x"));
            Assert.IsFalse(parser.Check("x1"));
            Assert.IsFalse(parser.Check("xy"));
            Assert.IsFalse(parser.Check("x+si"));
        }
    }
}
