using System;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordCompletion.Implem
{
    public class KeyWord<T> : IKeyWord where T : ICompareKey, new()
    {
        public KeyWord() { }
        public KeyWord(String sKey) { }

        public double Compare(IKeyWord key)
        {
            return new T().Compare(this, key);
        }
    }
}
