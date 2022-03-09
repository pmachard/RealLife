using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public class KeyWordResultItem : IKeyWordResultItem
    {
        public KeyWordResultItem() { }

        public KeyValuePair<string, int> Item { get ; set ; }
    }
}
