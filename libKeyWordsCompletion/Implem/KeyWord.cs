using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordCompletion.Implem
{
    public class KeyWord<T> : IKeyWord where T : ICompareKeys, new()
    {
        public string Key { get; set; }

        public KeyWord() { }
        public KeyWord(string s) { Key = s; }

        public int Compare(IKeyWord key)
        {
            return new T().Compare(this, key);
        }
    }
}
