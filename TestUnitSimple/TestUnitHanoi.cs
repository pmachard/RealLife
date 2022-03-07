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
            List<string> mvt = null;

            mvt = Hanoi.RunRecursive(1, 'A', 'B', 'C');
            Assert.AreEqual(new List<string> { "A>C" }, mvt);

            mvt = Hanoi.RunRecursive(2, 'A', 'B', 'C');
            Assert.AreEqual(new List<string> { "A>B","A>C","B>C" }, mvt);

            mvt = Hanoi.RunRecursive(3, 'A', 'B', 'C');
            Assert.AreEqual(new List<string> { "A>C", "A>B", "C>B", "A>C", "B>A", "B>C", "A>C" }, mvt);

            mvt = Hanoi.RunRecursive(4, 'A', 'B', 'C');
            Assert.AreEqual(new List<string> { "A>B", "A>C", "B>C", "A>B", "C>A", "C>B", "A>B", "A>C", "B>C", "B>A", "C>A", "B>C", "A>B", "A>C", "B>C" }, mvt);

            mvt = Hanoi.RunRecursive(5, 'A', 'B', 'C');
            Assert.AreEqual(new List<string> { 
                    "A>C","A>B","C>B","A>C","B>A","B>C","A>C","A>B","C>B","C>A","B>A",
                    "C>B","A>C","A>B","C>B","A>C","B>A","B>C","A>C","B>A","C>B","C>A",
                    "B>A","B>C","A>C","A>B","C>B","A>C","B>A","B>C","A>C"
            }, mvt);
        }
    }
}