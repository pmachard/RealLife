using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordCompletion.Implem
{
    public class KeyWord<T> : IKeyWord where T : ICompareKey, new()
    {
        public KeyWord() { }
        public KeyWord(string sKey) 
        { 
            Key = sKey; 
        }

        public string Key { get; set; }

        public int Compare(IKeyWord key)
        {
            return new T().Compare(this, key);
        }
    }
}
