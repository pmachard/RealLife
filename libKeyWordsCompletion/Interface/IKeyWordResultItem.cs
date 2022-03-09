using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface IKeyWordResultItem
    {
        KeyValuePair<string, int> Item { get; set; }
    }
}
