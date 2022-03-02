using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyEqual : ICompareKeys
    {
        public int Compare(IKeyWord leftWord, IKeyWord rightWord)
        {
            if (leftWord.Key == rightWord.Key)
                return 100;
            else
                return 0;
        }
    }
}

