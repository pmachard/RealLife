using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordsCompletion.UnitTest.Mock
{
    public class MockCompareKeyCharEqual : ICompareKey
    {
        public int Compare(string left, string right)
        {
            int minChar = Math.Min(left.Length, right.Length);

            double interResult = 0.0;

            for (int currentChar = 0; currentChar < minChar; currentChar++)
            {
                interResult += (left[currentChar] == right[currentChar]) ? 
                                    (100.0 / minChar) : 
                                    0.0;
            }
            return interResult > 100.0 ? 100 : (int)interResult;
        }
    }
}

