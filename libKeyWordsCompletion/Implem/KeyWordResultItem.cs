using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public class KeyWordResultItem : IKeyWordResultItem
    {
        public KeyWordResultItem() { }

        public IKeyWord Key { get; set; }
        public int Result { get; set; }
    }
}
