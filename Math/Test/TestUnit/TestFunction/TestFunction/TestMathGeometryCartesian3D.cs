using NUnit.Framework;
using Utopia.Math.Geometry.Cartesien.Implem;
using Utopia.Math.Geometry.Cartesien.Interface;


namespace Utopia.Math.Geometry.Cartesian.UnitTest  
{
    public class TestMathGeometryCartesian3D
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IVector3D c = new Vector3D(0.0f, 0.0f, 0.0f);
            Assert.Pass();
        }
    }
}