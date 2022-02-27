using System;
using System.Collections.Generic;
using Utopia.Algo.KeyWordCompletion.Interface;

namespace Utopia.Algo.KeyWordCompletion.Implem
{
    public class KeyWordSet<T> : IKeyWordSet where T : ICompareKey, new()
    {
        public List<string> Keys { get; set; }

        public int Compare(IKeyWordSet keys)
        {
            return 0;
        }
    }
}
