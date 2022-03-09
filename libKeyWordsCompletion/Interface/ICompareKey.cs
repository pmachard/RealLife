using System;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface ICompareKey
    {
        int Compare(IKeyWord leftWord, IKeyWord rightWord);
    }
}
