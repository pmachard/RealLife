using NUnit.Framework;
using libMath.Geometry.Cartesien.Implem;
using libMath.Geometry.Cartesien.Interface;


namespace TestMathGeometryCartesian
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