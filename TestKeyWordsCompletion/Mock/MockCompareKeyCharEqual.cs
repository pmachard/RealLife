using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyCharEqual : ICompareKeys
    {
        public int Compare(IKeyWord leftWord, IKeyWord rightWord)
        {
            int minChar = Math.Min(leftWord.Key.Length, rightWord.Key.Length);

            double interResult = 0.0;

            string strLeft = leftWord.Key.ToLower();
            string strRight = rightWord.Key.ToLower();

            for (int currentChar = 0; currentChar < minChar; currentChar++)
            {
                interResult += (strLeft[currentChar] == strRight[currentChar]) ? 
                                    (100.0 / minChar) : 
                                    0.0;
            }
            return interResult > 100.0 ? 100 : (int)interResult;
        }
    }
}

