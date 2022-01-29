using NUnit.Framework;
using libMath.Geometry.Cartesien.Implem;
using libMath.Geometry.Cartesien.Interface;


namespace TestMathGeometryCartesian
{
    public class TestMathGeometryCartesian2D
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IVector2D c = new Vector2D(0.0f, 0.0f);
            Assert.Pass();
        }
    }
}