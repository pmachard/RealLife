using NUnit.Framework;
using Utopia.Math.Geometry.Cartesien.Implem;
using Utopia.Math.Geometry.Cartesien.Interface;


namespace Utopia.Math.Geometry.Cartesian.UnitTest  
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