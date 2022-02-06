using NUnit.Framework;
using Utopia.Math.Function.Interface;
using Utopia.Math.Function.Implem;

namespace Utopia.Math.Function
{
    public class UnitTestElementConst
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestElementConstNew()
        {
            IElement<double> elment = new ElementConst<double>();
        }
    }
}