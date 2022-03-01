using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordCompletion.Implem
{
    public class KeyWordSet<T> : IKeyWordSet where T : ICompareSetKeys, new()
    {
        public KeyWordSet() { }
        public KeyWordSet(List<IKeyWord> sKeys) 
        {
            Keys = sKeys;
        }

        public List<IKeyWord> Keys { get; set; }

        List<IKeyWordResultItem> IKeyWordSet.Compare(IKeyWord rightKeyWord)
        {
            return new T().Compare(this, rightKeyWord);
        }
    }
}
