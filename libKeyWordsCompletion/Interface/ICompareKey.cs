using System;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface ICompareKey
    {
        int Compare(string left, string right);
    }
}
