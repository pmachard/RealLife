using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public interface ICompareSetKeys
    {
        List<IKeyWordResultItem> Compare(IKeyWordSet leftKeyWordSet, IKeyWord rightKeyWord);
    }
}
