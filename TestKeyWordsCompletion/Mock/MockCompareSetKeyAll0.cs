using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareSetKeyAll0 : ICompareSetKeys
    {
        public MockCompareSetKeyAll0()
        {
        }

        public MockCompareSetKeyAll0(string[] set)
        {
        }

        public List<IKeyWordResultItem> Compare(IKeyWordSet leftKeyWordSet, IKeyWord rightKeyWord)
        {
            List<IKeyWordResultItem> result = new List<IKeyWordResultItem>();
            foreach (IKeyWord keyWord in leftKeyWordSet.Keys)
            {
                keyWord.Compare(rightKeyWord);

                result.Add(new KeyWordResultItem());
            }
            return null;
        }
    }
}

