using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareSetKeyAl00 : ICompareKey
    {
        public MockCompareSetKeyAl00()
        {
        }

        public MockCompareSetKeyAl00(string[] set)
        {
        }

        public int Compare(IKeyWord leftWord, IKeyWord rightWord)
        {
            return 100;
        }
    }
}

