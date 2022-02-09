using NUnit.Framework;
using Utopia.Math.Function.Interface;
using Utopia.Math.Function.Implem;

namespace Utopia.Math.Function
{
    public class UnitTestElementExpr
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestElementConstNew()
        {
            IEl x = new ElVar("x");
            IEl Expr = x * new ElementConst(2.0);

            Assert.AreEqual("x*2.0", Expr.ToString());
        }
    }
}