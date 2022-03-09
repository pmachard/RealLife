using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyAll00 : ICompareKey
    {
        public int Compare(string left, string right)
        {
            return 100;
        }
    }
}

