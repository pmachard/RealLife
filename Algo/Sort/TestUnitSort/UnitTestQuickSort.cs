using NUnit.Framework;
using Utopia.Algo.Sort.Implem;

namespace Utopia.Algo.Sort.TestUnit
{
    public class UnitTestQuickSort
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestBubble()
        {
            int[] TabToSort = new int[] { 20,85,23,0,85,99,3,10};
            Assert.IsTrue(TestHelp.IsSorted(QuickSort.Run(TabToSort), TabToSort.Length));
        }
    }
}
