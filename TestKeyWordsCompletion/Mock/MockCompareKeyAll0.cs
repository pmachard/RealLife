using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyAll0 : ICompareSetKeys
    {
        public List<IKeyWordResultItem> Compare(IKeyWordSet leftKeyWordSet, IKeyWord rightKeyWord)
        {
            return null;
        }
    }
}

