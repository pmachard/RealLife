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
        public void TestElementConstEvaluate()
        {
            IEl expr = new ElConst(25.0);
            Assert.AreEqual(25.0, expr.Evaluate());
        }

        [Test]
        public void TestElementVarEvaluate()
        {
            IEl expr = new ElVar("x");
            expr.Fix(2.0);
            Assert.AreEqual(2.0, expr.Evaluate());
        }

        [Test]
        public void TestElementAddEvalute()
        {
            IEl expr = new ElAdd(new ElConst(10.0), new ElConst(20.0));
            Assert.AreEqual(30.0, expr.Evaluate());
        }

        [Test]
        public void TestElementSuppEvalute()
        {
            IEl expr = new ElSupp(new ElConst(10.0), new ElConst(20.0));
            Assert.AreEqual(-10.0, expr.Evaluate());
        }

        [Test]
        public void TestElementMultEvalute()
        {
            IEl expr = new ElMult(new ElConst(10.0), new ElConst(20.0));
            Assert.AreEqual(200.0, expr.Evaluate());
        }

        [Test]
        public void TestElementDivEvalute()
        {
            IEl expr = new ElDiv(new ElConst(10.0), new ElConst(20.0));
            Assert.AreEqual(0.50, expr.Evaluate());
        }

        [Test]
        public void TestElementVar()
        {
            IEl x = new ElVar("x");
            IEl expr = new ElMult(x, new ElConst(25.0));
            x.Fix(2.0);
            Assert.AreEqual(50.0, expr.Evaluate());
        }
    }
}
