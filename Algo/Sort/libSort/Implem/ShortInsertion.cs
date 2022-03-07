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

        private static int[] SortInsert(int[] tab)
        {
            int[] result = tab.Clone() as int[];
            int x,j;

            for (int i = 0; i < result.Length; i++)
            {
                x = result[i];
                j = i;

                while ((j > 0) && (result[j - 1] > x))
                {
                    result[j] = result[j - 1];
                    j = j - 1;
                    result[j] = x;
                }
            }
            return result;
        }
    }
}
