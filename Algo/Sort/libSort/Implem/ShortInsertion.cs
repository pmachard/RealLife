using System.Collections.Generic;
using Utopia.Algo.Sort.Interface;

namespace Utopia.Algo.Sort.Implem
{
    public class ShortInsertion : ISort
    {
        static public int[] Run(int[] tabSource)
        {
            return SortInsert(tabSource.Clone() as int[]);
        }

        private static int[] SortInsert(int[] a)
        {
            return a;
        }
    }
}
