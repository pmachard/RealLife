using NUnit.Framework;
using Utopia.Math.Symbolic.Interface;
using Utopia.Math.Symbolic.Implem;

namespace Utopia.Math.Symbolic.Test
{
    public class UnitTestMathSymbolicParserNumber
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestExpCheckEmpty()
        {
            /*
            IParser parser = new ParserNumber();

            string number = "123";
            ISymbolExp  exp = parser.Parse(number);
            */
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
            /*
            IParser parser = new Parser();
            Assert.IsTrue(parser.Check("x"));
            Assert.IsFalse(parser.Check("x1"));
            Assert.IsFalse(parser.Check("xy"));
            Assert.IsFalse(parser.Check("x+si"));
            Assert.IsTrue(parser.Check("x+y"));
            Assert.IsTrue(parser.Check("x+y+z"));
            Assert.IsTrue(parser.Check("x+2*y"));
            Assert.IsTrue(parser.Check("x*2+y"));
            Assert.IsTrue(parser.Check("x-y"));
            Assert.IsTrue(parser.Check("x-y+z"));
            Assert.IsTrue(parser.Check("x-2*y"));
            Assert.IsTrue(parser.Check("x*2-y"));
            */
        }
    }
}
