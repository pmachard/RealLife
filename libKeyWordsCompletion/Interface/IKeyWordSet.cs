using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface IKeyWordSet
    {
        List<IKeyWord> Keys { get; set; }
        int Compare(IKeyWordSet keys);
    }
}
