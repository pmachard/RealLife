using Utopia.Math.Function.implem;
using Utopia.Math.Function.Implem;
using Utopia.Math.Function.Interface;
using NUnit.Framework;

          
namespace Utopia.Math.Function.UnitTest
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