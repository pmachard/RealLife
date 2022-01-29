using System;
using NUnit.Framework;
using Math.Function.Interface;
using Math.Function.implem;


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
            ICell<Double> cell = new Cell<Double>();

            Assert.IsNotNull(cell);
        }

        [Test]
        public void TestElementCreate()
        {
            IElement<Double> cell = new ElementConst<Double>();

            Assert.IsNotNull(cell);
        }
    }
}