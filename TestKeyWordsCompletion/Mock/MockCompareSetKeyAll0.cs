using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareSetKeyAll0 : ICompareSetKeys
    {
        public List<IKeyWordResultItem> Compare(IKeyWordSet leftKeyWordSet, IKeyWord rightKeyWord)
        {
            List<IKeyWordResultItem> result = new List<IKeyWordResultItem>();
            foreach (IKeyWord keyWord in leftKeyWordSet.Keys)
            {
                // result.Add(null, null);
            }
            return null;
        }
    }
}

