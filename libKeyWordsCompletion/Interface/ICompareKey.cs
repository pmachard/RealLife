using System;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface ICompareKeys
    {
        int Compare(IKeyWord leftWord, IKeyWord rightWord);
    }
}
