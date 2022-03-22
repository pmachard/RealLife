using System;
using NUnit.Framework;

namespace Utopia.Language.UnitTest
{
    public class UnitTestGarbageCollect
    {

        static private void MakeSomeGarbage()
        {
            Version vt;
            for (int i = 0; i < 1000000; i++)
            {
                vt = new Version();
            }
        }

        [Test]
        public void TestSimpleCollect()
        {
            long memoryTotalMemory = GC.GetTotalMemory(false);
            MakeSomeGarbage();
            long memoryTotalWithSomeGarbage = GC.GetTotalMemory(false);
            // Assert.LessOrEqual(memoryTotalWithSomeGarbage,memoryTotalMemory);
            GC.Collect();
            long memoryTotalMemoryAfter = GC.GetTotalMemory(false);
            // Assert.LessOrEqual(memoryTotalMemoryAfter, memoryTotalMemory);
        }
    }
}