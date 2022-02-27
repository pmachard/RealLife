using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyAll00 : ICompareKey
    {
        public int Compare(IKeyWord leftWord, IKeyWord rightWord)
        {
            return 100;
        }
    }
}

