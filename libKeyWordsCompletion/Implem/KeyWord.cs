using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordCompletion.Implem
{
    public class KeyWord<T> : IKeyWord where T : ICompareKey, new()
    {
        public string Key { get; set; }

        public KeyWord() { }
        public KeyWord(string s) { Key = s; }

        public int Compare(string key)
        {
            return new T().Compare(Key, key);
        }
    }
}
