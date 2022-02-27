using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface IKeyWordResultItem
    {
        IKeyWord Key { get; set; }
        int Result { get; set; }
    }
}
