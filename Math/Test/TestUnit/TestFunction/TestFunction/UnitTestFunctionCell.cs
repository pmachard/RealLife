using Math.Function.implem;
using Math.Function.Implem;
using Math.Function.Interface;
using NUnit.Framework;

namespace Math.Function.UnitTest
{
    public class UnitTestFunctionCell
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCellCreate()
        {
            ICell<double> cell = new Cell<double>();

            Assert.IsNotNull(cell);
        }

        [Test]
        public void TestElementCreate()
        {
            IElement<double> cell = new ElementConst<double>();

            Assert.IsNotNull(cell);
        }
    }
}