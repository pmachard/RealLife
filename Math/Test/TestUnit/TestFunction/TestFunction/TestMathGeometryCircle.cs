using NUnit.Framework;
using Utopia.Math.Geometry.d2.Implem;


namespace Utopia.Math.Geometry.Cartesian.UnitTest  
{
    public class TestMathGeometryCircle
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreate()
        {
            Assert.IsNotNull(new Circle());
        }

        [Test]
        public void TestCreateParameter()
        {
            Circle c = new Circle(1.0);
            Assert.AreEqual(1.0, c.R);
        }

        [Test]
        public void TestCreatePerimeter()
        {
            Circle c = new Circle(1.0);
            Assert.AreEqual(2.0 * System.Math.PI, c.ComputePerimeter());
        }

        [Test]
        public void TestCreateArea()
        {
            Circle c = new Circle(1.0);
            Assert.AreEqual(System.Math.PI * 1.0, c.ComputeArea());
        }
    }
}