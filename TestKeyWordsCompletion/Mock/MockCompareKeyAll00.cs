using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyAll00 : ICompareKeys
    {
        public int Compare(IKeyWord leftWord, IKeyWord rightWord)
        {
            return 100;
        }
    }
}

