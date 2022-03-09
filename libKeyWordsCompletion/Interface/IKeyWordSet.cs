using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Implem;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface IKeyWordSet
    {
        List<string> Keys { get; set; }
        List<IKeyWordResultItem> Compare(string key);
    }
}
