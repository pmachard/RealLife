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
            Assert.IsNotNull(new Circle(1.0));
        }
    }
}