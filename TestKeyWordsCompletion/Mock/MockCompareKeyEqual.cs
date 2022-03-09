using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyEqual : ICompareKey
    {
        public int Compare(string left, string right)
        {
            if (left == right)
                return 100;
            else
                return 0;
        }
    }
}

