using NUnit.Framework;
using Utopia.Algo.Sort.Implem;

namespace Utopia.Algo.Sort.TestUnit
{
    public class TestsSortBubble
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestBubble()
        {
            int[] TabToSort = new int[] { 20,85,23,0,85,99,3,10};
            Assert.IsFalse(TestHelp.IsSorted(SubbleBubble.Run(TabToSort), TabToSort.Length));
        }
    }
}
