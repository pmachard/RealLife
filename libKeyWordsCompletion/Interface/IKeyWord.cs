using System;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface IKeyWord
    {
        string Key { get; set; }
        int Compare(IKeyWord key);
    }
}
