using NUnit.Framework;
using System.Collections.Generic;
using Utopia.Algo.Simple;

namespace Utopia.Algo.Simple.TestUnit
{
    public class TestUnitHanoi
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSimple()
        {
            int n = 3;
            char D = 'A';
            char A = 'B';
            char I = 'C';

            List<string> result = Hanoi.Run(n, D, A, I);
            Assert.IsNotNull(result);
        }
    }
}