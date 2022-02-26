using System;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface ICompareKey
    {
        double Compare(IKeyWord leftWord, IKeyWord rightWord);
    }
}
