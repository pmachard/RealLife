using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyAll0 : ICompareKey
    {
        public int Compare(IKeyWord left, IKeyWord right)
        {
            return 0;
        }
    }
}

