using System;
using System.Collections.Generic;

namespace Utopia.Algo.KeyWordCompletion.Interface
{
    public class KeyWordResultItem : IKeyWordResultItem
    {
        public KeyWordResultItem() 
        { 
        }

        public KeyWordResultItem(string key, int result) 
        { 
            Item = new KeyValuePair<string, int>(key, result); 
        }

        public KeyValuePair<string, int> Item { get ; set ; }
    }
}
